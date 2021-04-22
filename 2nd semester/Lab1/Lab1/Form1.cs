using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
	public partial class Form1 : Form
	{
		//My functions
		private double calculate_value(double A, double x)
		{
			try
			{
				if (x < (4 * A))
				{
					return Math.Sqrt(16 * Math.Pow(A, 2) - Math.Pow((x - 4 * A), 2));
				}
				else
				{
					return (8 * Math.Pow(A, 3)) / (Math.Pow((x - 4 * A), 2) + 4 * Math.Pow(A, 2));
				}
			}
			catch
			{
				MessageBox.Show("Failed to calculate value for x = " + Convert.ToString(x));
				return Double.NaN;
			}
		}

		private double calculate_difference(int i, int j, int[,] Matrix)
		{
			try
			{
				return Math.Abs(Convert.ToDouble(Matrix.Rows[i].Cells[j].Value) - Convert.ToDouble(Matrix.Rows[i].Cells[i].Value));
			}
			catch
			{
				MessageBox.Show("Failed to calculate difference.");
				return Double.NaN;
			}
		}

		//

		public Form1()
		{
			InitializeComponent();
			dataGridView2.RowCount = 4;
			dataGridView2.ColumnCount = 4;
			dataGridView3.RowCount = 1;
			dataGridView3.ColumnCount = 4;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int N = Convert.ToInt32(textBox4.Text);
				double A = Convert.ToDouble(textBox1.Text);
				double x1 = Convert.ToDouble(textBox2.Text);
				double dx = Convert.ToDouble(textBox3.Text);
				dataGridView1.RowCount = N;
				dataGridView1.ColumnCount = 3;
				double curr_x = x1;
				for (int i = 0; i < N; i++)
				{
					dataGridView1.Rows[i].Cells[0].Value = i + 1;
					dataGridView1.Rows[i].Cells[1].Value = "x = " + Convert.ToString(Math.Round(curr_x, 5));
					dataGridView1.Rows[i].Cells[2].Value = "y = " + Convert.ToString(Math.Round(calculate_value(A, curr_x), 5));
					curr_x += dx;
				}
			}
			catch
			{
				MessageBox.Show("Incorrect input. Try again.");
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label5_Click_1(object sender, EventArgs e)
		{

		}

		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				double difference;
				for (int i = 0; i < 4; i++)
				{
					difference = 0.0;
					for (int j = 0; j < 4; j++)
					{
						difference = Math.Max(difference, calculate_difference(i, j, dataGridView2));
					}
					dataGridView3.Rows[0].Cells[i].Value = difference;
				}
			}
			catch
			{
				MessageBox.Show("Incorrect input. Try again.");
			}
		}
	}
}
