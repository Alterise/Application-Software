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

namespace Server
{
	public partial class Form1 : Form
	{
		class ClientInfo
		{
			public Socket socket;
			public int number;

			public override string ToString()
			{
				return "Ползователь №" + number + " (" + socket.RemoteEndPoint + ")";
			}
		}

		TcpListener listener;
		List<ClientInfo> clients;
		private int counter = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonBind_Click(object sender, EventArgs e)
		{
			try
			{
				int local_port = Int32.Parse(textBoxLocalPort.Text);
				IPEndPoint local_point = new IPEndPoint(IPAddress.Any, local_port);
				listener = new TcpListener(local_point);
				listener.Start();
				clients = new List<ClientInfo>();
				timer1.Enabled = true;
				textBoxLog.AppendText("Открыт TCP порт " + textBoxLocalPort.Text + "\r\n");
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
				CheckListener();

				foreach (var client in clients)
				{
					if(client.socket.Available > 0)
					{
						byte[] data = new byte[client.socket.Available];
						int data_size = client.socket.Receive(data);
						string text_data = Encoding.UTF8.GetString(data, 0, data_size);
						GetClientInstruction(client, text_data);
					}
				}
			}
			catch (Exception ex)
			{
				textBoxLog.AppendText(ex.Message + "\r\n");
			}
		}

		private void CheckListener()
		{
			if(listener.Pending())
			{
				counter++;
				ClientInfo new_client = new ClientInfo();
				new_client.socket = listener.AcceptSocket();
				new_client.number = counter;
				clients.Add(new_client);
				textBoxLog.AppendText("Пользователь " + new_client.socket.RemoteEndPoint + 
									  " подключился и получил номер " + new_client.number + "\r\n");
			}
		}

		private void GetClientInstruction(ClientInfo client, string text_data)
		{
			if(text_data.StartsWith("expression "))
			{
				string expression = text_data.Substring(11);
				string[] tokens = expression.Split(' ');
				try
				{
					double left_operand = Double.Parse(tokens[0]);
					char operation = Char.Parse(tokens[1]);
					double right_operand = Double.Parse(tokens[2]);
					if(operation == '+')
					{
						SendToClient((left_operand + right_operand).ToString(), client);
					}
					else if (operation == '-')
					{
						SendToClient((left_operand - right_operand).ToString(), client);
					}
					else if (operation == '*')
					{
						SendToClient((left_operand * right_operand).ToString(), client);
					}
					else if (operation == '/')
					{
						SendToClient((left_operand / right_operand).ToString(), client);
					}
					else
					{
						throw new Exception();
					}
				}
				catch (Exception ex)
				{
					textBoxLog.AppendText("Клиент №" + client.number + " столкнулся с проблемой: " +
										  ex.Message + "\r\n");
					SendToClient("Что-то пошло не так, попробуйте ещё раз", client);
				}
			}
			
			if(text_data == "quit")
			{
				textBoxLog.AppendText("Пользователь №" + client.number + " отключился\r\n");
				client.socket.Shutdown(SocketShutdown.Both);
				client.socket.Close();
				clients.Remove(client);
			}
			
		}

		private void SendToClient(string text_to_send, ClientInfo client)
		{
			try
			{
				byte[] data = Encoding.UTF8.GetBytes(text_to_send);
				client.socket.Send(data);
			}
			catch (Exception ex)
			{
				textBoxLog.AppendText(ex.Message + "\r\n");
			}
		}
	}
}
