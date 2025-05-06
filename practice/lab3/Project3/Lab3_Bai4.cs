using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project3
{
    public partial class Lab3_Bai4 : Form
    {
        TcpListener server;
        List<TcpClient> clients = new List<TcpClient>();
        bool isRunning = false;

        public Lab3_Bai4()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void StartServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            server.Start();
            isRunning = true;
            UpdateMessage("Server started...");

            while (isRunning)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);
                UpdateMessage("Client connected: " + client.Client.RemoteEndPoint.ToString());

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (client.Connected)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    UpdateMessage(message);
                    BroadcastMessage(message, client);
                }
                catch
                {
                    UpdateMessage("Client disconnected.");
                    clients.Remove(client);
                    break;
                }
            }
        }

        private void BroadcastMessage(string message, TcpClient excludeClient)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                if (client.Connected)
                {
                    try
                    {
                        client.GetStream().Write(data, 0, data.Length);
                    }
                    catch { }
                }
            }
        }

        private void UpdateMessage(string message)
        {
            if (tbMessage.InvokeRequired)
            {
                tbMessage.Invoke(new Action(() => tbMessage.AppendText(message + Environment.NewLine)));
            }
            else
            {
                tbMessage.AppendText(message + Environment.NewLine);
            }
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            Lab3_Bai4_ChatClient bai4_client = new Lab3_Bai4_ChatClient();
            bai4_client.Show();
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
