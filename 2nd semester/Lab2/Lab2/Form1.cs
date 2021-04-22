using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
	public partial class Form1 : Form
	{
		float func(float x)
		{
			return (float)(Math.Log(Math.Sqrt(Math.PI + Math.Abs(2.0 - x))) / (3.0 - 1.0 / x) + 
			Math.Pow(Math.Pow(x, 2.0), 1.0 / 3.0) * Math.Sin(1.4 * x));
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			float x_lb, x_rb;
			try
			{
				x_lb = (float)Convert.ToDouble(textBox1.Text);
				x_rb = (float)Convert.ToDouble(textBox2.Text);
			}
			catch(Exception excp)
			{
				MessageBox.Show("Некорректный ввод");
				return;
			}
			//Конфигурационные переменные
			int point_count = 1000;
			float win_size_x = 600, win_size_y = 400;
			float x_shift = 50, y_shift = 50, graph_shift = (win_size_y - 2 * y_shift) / 2;
			float step_x = (win_size_x - 2 * x_shift) / point_count;
			float step_y = (x_rb - x_lb) / point_count;
			float y_scale;
			float max_y_deviation = Math.Abs(-func(x_lb));

			PointF[] points = new PointF[point_count];
			for(int i = 0; i < point_count; i++)
			{
				points[i] = new PointF(i * step_x + x_shift, 
				-func(x_lb + step_y * i));
				if(max_y_deviation < Math.Abs(-func(x_lb + step_y * i))) 
					max_y_deviation = Math.Abs(-func(x_lb + step_y * i));
			}
			y_scale = ((win_size_y - 2 * y_shift) / 2) / max_y_deviation * (float)0.9;
			for (int i = 0; i < point_count; i++)
			{
				points[i].Y = points[i].Y * y_scale + y_shift + graph_shift;
			}
			Graphics gr = pictureBox1.CreateGraphics();
			gr.Clear(Color.Black);

			Pen my_pen = new Pen(Color.Lime, 2);
			Pen my_pen2 = new Pen(Color.White, 2);
			Font my_font = new Font("Times New Roman", 15);
			gr.DrawLines(my_pen, points);
			gr.DrawLine(my_pen, x_shift, win_size_y - y_shift, win_size_x - x_shift, win_size_y - y_shift);
			gr.DrawLine(my_pen, x_shift, y_shift, x_shift, win_size_y - y_shift);
			//Отметки
			gr.DrawLine(my_pen, x_shift - 5, win_size_y - y_shift, x_shift + 5, win_size_y - y_shift);
			gr.DrawLine(my_pen, x_shift - 5, y_shift, x_shift + 5, y_shift);
			gr.DrawLine(my_pen, win_size_x - x_shift, win_size_y - y_shift - 5, win_size_x - x_shift, win_size_y - y_shift + 5);
			gr.DrawLine(my_pen, x_shift, win_size_y - y_shift - 5, x_shift, win_size_y - y_shift + 5);
			//Оси
			gr.DrawString("y", my_font, my_pen.Brush, x_shift - 8, y_shift - 30);
			gr.DrawString("x", my_font, my_pen.Brush, win_size_x - 45, win_size_y - 65);
			//Цифры
			gr.DrawString(Convert.ToString(Math.Round(max_y_deviation * 0.9)), my_font, my_pen.Brush, 5, y_shift - 10);
			gr.DrawString(Convert.ToString(Math.Round(-max_y_deviation * 0.9)), my_font, my_pen.Brush, 5, win_size_y - 60);
			gr.DrawString(Convert.ToString(x_lb), my_font, my_pen.Brush, 40, win_size_y - 40);
			gr.DrawString(Convert.ToString(x_rb), my_font, my_pen.Brush, win_size_x - 60, win_size_y - 40);
		}
	}
}
