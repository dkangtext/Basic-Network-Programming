using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project3
{
    public partial class Lab3_Bai3 : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        static ASCIIEncoding encoding = new ASCIIEncoding();

        public Lab3_Bai3()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            btListen.Text = "LISTENING";
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ListenForClients()
        {
            try
            {
                int port = 8080;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                tcpListener = new TcpListener(localAddr, port);
                tcpListener.Start();

                this.Invoke(new Action(() =>
                {
                    AddToListView("Waiting for a connection...");
                    btListen.Text = "LISTENING";
                }));

                while (true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();

                    this.Invoke(new Action(() =>
                    {
                        AddToListView("Client connected.");
                    }));

                    Thread clientThread = new Thread(() => HandleClientComm(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void HandleClientComm(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[256];
                StringBuilder messageBuilder = new StringBuilder();
                int bytesRead;

                while ((bytesRead = stream.Read(data, 0, data.Length)) > 0)
                {
                    string part = encoding.GetString(data, 0, bytesRead);
                    messageBuilder.Append(part);

                    // Kiểm tra nếu có ký tự xuống dòng: xử lý từng dòng một
                    while (messageBuilder.ToString().Contains("\n"))
                    {
                        string fullText = messageBuilder.ToString();
                        int newlineIndex = fullText.IndexOf("\n");

                        string line = fullText.Substring(0, newlineIndex).Trim();
                        messageBuilder.Remove(0, newlineIndex + 1);

                        this.Invoke(new Action(() =>
                        {
                            AddToListView("Received: " + line);
                        }));

                        if (line == "Quit Server")
                        {
                            client.Close();
                            this.Invoke(new Action(() =>
                            {
                                AddToListView("Client disconnected.");
                                btListen.Text = "LISTEN";
                            }));
                            return;
                        }
                    }
                }

                client.Close();
                this.Invoke(new Action(() =>
                {
                    AddToListView("Client disconnected.");
                    btListen.Text = "LISTEN";
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    AddToListView("Lỗi khi xử lý client: " + ex.Message);
                }));
            }
        }


        private void AddToListView(string message)
        {
            lvListen.Items.Add(new ListViewItem(message));
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            tcpListener.Stop();
            this.Close();
        }

        private void lvListen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
