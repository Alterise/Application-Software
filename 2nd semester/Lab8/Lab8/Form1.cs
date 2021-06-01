using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Lab8
{
	public partial class Form1 : Form
	{
		static int rowsCount;
		static int columnsCount;
		static int[,] matrix;
		static int[,] backup_matrix;
		static Stopwatch StopWatch = new Stopwatch();

		public Form1()
		{
			InitializeComponent();
		}

		private (int, int) SingleThreadProcessing()
		{
			int sum = 0;
			int replaces = 0;
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
				{
					sum += matrix[i, j];
					if (((i + 1) % 2 == 0) && (matrix[i, j] < 0))
					{
						matrix[i, j] = 1;
						replaces++;
					} 
				}
			}
			return (sum, replaces);
		}

		private (int, int) rowProcessing(int rowNumber)
		{
			int sum = 0;
			int replaces = 0;

			for (int i = 0; i < columnsCount; i++)
			{
				sum += matrix[rowNumber, i];
				if (((rowNumber + 1) % 2 == 0) && (matrix[rowNumber, i] < 0))
				{
					matrix[rowNumber, i] = 1;
					replaces++;
				}
			}

			return (sum, replaces);
		}

		private (int, int) MultiThreadProcessing()
		{
			int sum = 0;
			int replaces = 0;
			List<Thread> threads = new List<Thread>();
			List<(int, int)> results = new List<(int, int)>();
			for (int i = 0; i < rowsCount - 1; i++)
			{
				int _i = i;
				results.Add((0, 0));
				threads.Add(new Thread(() =>
				{
					results[_i] = rowProcessing(_i + 1);
				}));
				threads[_i].Start();
			}

			for (int i = 0; i < columnsCount; i++)
			{
				{
					sum += matrix[0, i];
				}
			}

			for (int i = 0; i < (rowsCount - 1); i++)
			{
				threads[i].Join();
				sum += results[i].Item1;
				replaces += results[i].Item2;
			}

			return (sum, replaces);
		}

		private void dataTableInsertion()
		{
			dataGridView1.RowCount = rowsCount;
			dataGridView1.ColumnCount = columnsCount;
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
				{
					dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
				}
			}
		}

		private void dataTableTake()
		{
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
				{
					matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
				}
			}
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			try
			{
				rowsCount = Int32.Parse(rowsTextBox.Text);
				columnsCount = Int32.Parse(columnsTextBox.Text);
				matrix = new int[rowsCount, columnsCount];
				Random rnd = new Random();
				for (int i = 0; i < rowsCount; i++)
				{
					for (int j = 0; j < columnsCount; j++)
					{
						matrix[i, j] = rnd.Next(-50, 50);
					}
				}
				dataTableInsertion();
				singleThreadButton.Enabled = true;
				multiThreadButton.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void backupMatrix()
		{
			backup_matrix = new int[rowsCount, columnsCount];
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
				{
					backup_matrix[i, j] = matrix[i, j];
				}
			}
		}

		private void singleThreadButton_Click(object sender, EventArgs e)
		{
			try
			{
				dataTableTake();
				backupMatrix();
				StopWatch.Start();
				var tmp = SingleThreadProcessing();
				sumTextBox.Text = tmp.Item1.ToString();
				replacesTextBox.Text = tmp.Item2.ToString();
				StopWatch.Stop();
				execTimeTextBox.Text = StopWatch.Elapsed.ToString() + "s";
				StopWatch.Reset();
				dataTableInsertion();
				redoButton.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void multiThreadButton_Click(object sender, EventArgs e)
		{
			try
			{
				dataTableTake();
				backupMatrix();
				StopWatch.Start();
				var tmp = MultiThreadProcessing();
				sumTextBox.Text = tmp.Item1.ToString();
				replacesTextBox.Text = tmp.Item2.ToString();
				StopWatch.Stop();
				execTimeTextBox.Text = StopWatch.Elapsed.ToString() + "s";
				StopWatch.Reset();
				dataTableInsertion();
				redoButton.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void redoButton_Click(object sender, EventArgs e)
		{
			try
			{
				matrix = backup_matrix;
				dataTableInsertion();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
