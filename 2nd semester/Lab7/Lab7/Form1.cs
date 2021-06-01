using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
	public partial class Form1 : Form
	{
		private static double[,] eulerPoints = new double[2, 11];
		private static double[,] rungeKuttaPoints = new double[2, 11];
		private static double[,] rungeKuttaYsPoints = new double[4, 11];

		private double func(double x, double y)
		{
			return x * x - y * y;
		}

		public Form1()
		{
			InitializeComponent();
			dataGridView2.ColumnCount = 2;
			dataGridView2.RowCount = 11;
			dataGridView1.ColumnCount = 2;
			dataGridView1.RowCount = 11;
			dataGridView2.Columns[0].HeaderText = "X";
			dataGridView2.Columns[1].HeaderText = "Y";
			dataGridView1.Columns[0].HeaderText = "X";
			dataGridView1.Columns[1].HeaderText = "Y";

			double val = 0.0;
			for (int i = 0; i <= 10; i++)
			{
				dataGridView1.Rows[i].Cells[0].Value = val;
				dataGridView1.Rows[i].Cells[1].Value = "---";
				dataGridView2.Rows[i].Cells[0].Value = val;
				dataGridView2.Rows[i].Cells[1].Value = "---";
				eulerPoints[0, i] = val;
				eulerPoints[1, i] = 0;
				rungeKuttaPoints[0, i] = val;
				rungeKuttaPoints[1, i] = 0;
				val += 0.1;
			}
		}

		private void eulerMethod()
		{
			eulerPoints[1, 0] = 1;
			for (int i = 1; i < 11; i++)
			{
				double h = 0.1;
				eulerPoints[1, i] = eulerPoints[1, i - 1] + h * func(eulerPoints[0, i - 1], eulerPoints[1, i - 1]);
			}
		}

		private void rungeKuttaMethod()
		{
			rungeKuttaPoints[1, 0] = 1;
			for (int i = 1; i < 11; i++)
			{
				double h = 0.1;
				rungeKuttaYsPoints[0, i] = h * func(rungeKuttaPoints[0, i - 1], rungeKuttaPoints[1, i - 1]);
				rungeKuttaYsPoints[1, i] = h * func(rungeKuttaPoints[0, i - 1] + h / 2.0, rungeKuttaPoints[1, i - 1] + rungeKuttaYsPoints[0, i] / 2.0);
				rungeKuttaYsPoints[2, i] = h * func(rungeKuttaPoints[0, i - 1] + h / 2.0, rungeKuttaPoints[1, i - 1] + rungeKuttaYsPoints[1, i] / 2.0);
				rungeKuttaYsPoints[3, i] = h * func(rungeKuttaPoints[0, i - 1] + h, rungeKuttaPoints[1, i - 1] + rungeKuttaYsPoints[2, i]);
				rungeKuttaPoints[1, i] = rungeKuttaPoints[1, i - 1] + (rungeKuttaYsPoints[0, i] + 2 * rungeKuttaYsPoints[1, i] + 2 * rungeKuttaYsPoints[2, i] + rungeKuttaYsPoints[3, i]) / 6.0;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				chart1.Series[0].Points.Clear();
				eulerMethod();
				for (int i = 0; i < 11; i++)
				{
					chart1.Series[0].Points.AddXY(eulerPoints[0, i], eulerPoints[1, i]);
					dataGridView1.Rows[i].Cells[1].Value = eulerPoints[1, i];
				}
				button1.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				chart1.Series[1].Points.Clear();
				rungeKuttaMethod();
				for (int i = 0; i < 11; i++)
				{
					chart1.Series[1].Points.AddXY(rungeKuttaPoints[0, i], rungeKuttaPoints[1, i]);
					dataGridView2.Rows[i].Cells[1].Value = rungeKuttaPoints[1, i];
				}
				button2.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				chart1.Series[0].Points.Clear();
				chart1.Series[1].Points.Clear();
				for (int i = 0; i < 11; i++)
				{
					eulerPoints[1, i] = 0;
					dataGridView1.Rows[i].Cells[1].Value = "---";
					rungeKuttaPoints[1, i] = 0;
					dataGridView2.Rows[i].Cells[1].Value = "---";
				}
				button1.Enabled = true;
				button2.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
