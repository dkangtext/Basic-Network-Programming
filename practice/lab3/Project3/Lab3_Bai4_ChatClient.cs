using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project3
{
    public partial class Lab3_Bai4_ChatClient : Form
    {
        TcpClient client;
        NetworkStream stream;

        public Lab3_Bai4_ChatClient()
        {
            InitializeComponent();
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            client = new TcpClient("127.0.0.1", 8080);
            stream = client.GetStream();

            Thread receiveThread = new Thread(ReceiveMessages);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) continue;
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    UpdateChat(message);
                }
                catch
                {
                    UpdateChat("Disconnected from server.");
                    break;
                }
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text.Trim() != "")
            {
                string message = $"{tbName.Text}: {tbMessage.Text}";
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                tbMessage.Clear();
            }
        }

        private void UpdateChat(string message)
        {
            if (tbChat.InvokeRequired)
            {
                tbChat.Invoke(new Action(() => tbChat.AppendText(message + Environment.NewLine)));
            }
            else
            {
                tbChat.AppendText(message + Environment.NewLine);
            }
        }
    }
}
