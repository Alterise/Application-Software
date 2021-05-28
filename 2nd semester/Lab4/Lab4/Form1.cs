using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class Form1 : Form
	{
		private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;";
		private static SqlConnection sqlConnection = new SqlConnection(connectionString);


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void findButton_Click(object sender, EventArgs e)
		{
			try 
			{
				sqlConnection.Close();
				sqlConnection.Open();
				if (findTextBox.TextLength == 0)
				{
					MessageBox.Show("Please, enter the text");
					sqlConnection.Close();
					return;
				}

				SqlDataAdapter dataAdapter = null;
				if (nameOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE Name='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (shortNameOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE ShortName='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (atomicNumberOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE AtomicNumber='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (periodOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE Period='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (groupOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE GroupNumber='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (atomicMassOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE AtomicMass='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (typeOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE Type='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (infoOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE Info='" + findTextBox.Text + "'", sqlConnection);
				}
				else if (electronCountOption.Checked)
				{
					dataAdapter = new SqlDataAdapter("select * from PeriodicTable WHERE ElectronCount='" + findTextBox.Text + "'", sqlConnection);
				}
				else
				{
					MessageBox.Show("Please, choose the find option");
					sqlConnection.Close();
					return;
				}
				DataTable dataTable = new DataTable();
				dataAdapter.Fill(dataTable);
				dataGridView1.DataSource = dataTable;
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
}

		private void showFullButton_Click(object sender, EventArgs e)
		{
			try
			{
				sqlConnection.Close();
				sqlConnection.Open();
				SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from PeriodicTable", sqlConnection);
				DataTable dataTable = new DataTable();
				dataAdapter.Fill(dataTable);
				dataGridView1.DataSource = dataTable;
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
