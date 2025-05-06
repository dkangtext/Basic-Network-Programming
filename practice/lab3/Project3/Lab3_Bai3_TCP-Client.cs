using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project3
{
    public partial class Lab3_Bai3_TCP_Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Lab3_Bai3_TCP_Client()
        {
            InitializeComponent();
            Lab3_Bai3_TCP_Client_Load();
        }
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 8080;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        private void Lab3_Bai3_TCP_Client_Load()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", PORT_NUMBER);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối: " + ex.Message);
            }
        }
        private void btSendMessages_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    MessageBox.Show("Chưa kết nối đến server.");
                    return;
                }

                string message = "Hello Server\n";
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi: " + ex.Message);
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (stream != null)
                {
                    byte[] data = Encoding.UTF8.GetBytes("Quit Server\n");
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }

                if (client != null)
                {
                    client.Close();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }
    }
}
