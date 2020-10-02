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
using System.Threading;

namespace Lab2SetProgClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
            
            InitializeComponent();
            IPAddress address = IPAddress.Parse(Server.Host);
            Server.ServerSocket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Server.ServerSocket.Bind(new IPEndPoint(address, Server.Port));
            Server.ServerSocket.Listen(100);
            label1.Text = $"Сервер запущен на {Server.Host}:{Server.Port}. Ожидается подключение пользователей";
            Console.WriteLine("Waiting connections...");
            Thread thread2 = new Thread(new ThreadStart(RunServer));
            thread2.Start();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void RunServer()
		{
            
            while (Server.Work)
            {
                Socket handle = Server.ServerSocket.Accept();
                new User(handle);

            }
            Console.WriteLine("Server closeing...");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"Сервер запущен на {Server.Host}:{Server.Port}";
            
        }
    }
}
