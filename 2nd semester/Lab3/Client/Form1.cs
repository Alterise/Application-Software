using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
	public partial class Client : Form
	{
		Socket socket;

		public Client()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			try
			{
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket.Connect(textBoxHost.Text, Int32.Parse(textBoxPort.Text));
				timer1.Enabled = true;
				textBoxLog.AppendText("Подключено к " + textBoxHost.Text + ":" + textBoxPort.Text + "\r\n");
				buttonConnect.Enabled = false;
				buttonDisconnect.Enabled = true;
			}
			catch (Exception ex)
			{
				textBoxLog.AppendText(ex.Message + "\r\n");
			}
		}

		private void SendToServer(string instruction)
		{
			byte[] data = Encoding.UTF8.GetBytes(instruction);
			socket.Send(data);
		}

		private void buttonDisconnect_Click(object sender, EventArgs e)
		{
			try
			{
				SendToServer("quit");
				socket.Shutdown(SocketShutdown.Both);
				socket.Close();
				timer1.Enabled = false;
				buttonConnect.Enabled = true;
				buttonDisconnect.Enabled = false;
				textBoxLog.AppendText("Отключено\r\n");
			}
			catch (Exception ex)
			{
				textBoxLog.AppendText(ex.Message + "\r\n");
			}

		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			try
			{
				SendToServer("expression " + textBoxExpression.Text);
			}
			catch (Exception ex)
			{
				textBoxLog.AppendText(ex.Message + "\r\n");
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if(socket.Available > 0)
				{
					byte[] data = new byte[socket.Available];
					int data_size = socket.Receive(data);
					string text_data = Encoding.UTF8.GetString(data, 0, data_size);
					textBoxLog.AppendText(text_data + "\r\n");
				}
				
			}
			catch (Exception ex)
			{
				textBoxLog.AppendText(ex.Message + "\r\n");
			}
		}
	}
}
