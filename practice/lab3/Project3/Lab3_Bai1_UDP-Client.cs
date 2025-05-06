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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project3
{
    public partial class Lab3_Bai1_UDP_Server : Form
    {
        public Lab3_Bai1_UDP_Server()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();

                //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAddress
                IPAddress ipadd = IPAddress.Parse(tbIPRemote.Text);
                int port = Convert.ToInt32(tbPort.Text);
                IPEndPoint ipend = new IPEndPoint(ipadd, port);

                //Chuyển chuỗi dữ liệu nhập sang kiểu byte
                Byte[] sendBytes = Encoding.UTF8.GetBytes(tbMessage.Text);

                //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
                udpClient.Send(sendBytes, sendBytes.Length, ipend);

                //Xóa dữ liệu vừa gửi ở ô nhập
                tbMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
