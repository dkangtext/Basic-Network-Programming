﻿using System;
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
    public partial class Lab3_Bai1_U_Server : Form
    {
        UdpClient udpServer;
        public Lab3_Bai1_U_Server()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            try
            {
                int port = Convert.ToInt32(tbPort.Text);
                UdpClient udpServer = new UdpClient(port);
                while (true)
                {
                    IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, port);
                    btListen.Text = "Listening";
                    tbPort.ReadOnly = true;
                    var recvByte = new Byte[1];
                    recvByte = udpServer.Receive(ref IpEnd);
                    string Data = Encoding.UTF8.GetString(recvByte);
                    string mess = IpEnd.Address.ToString() + ": " + Data.ToString();
                    tbReceivedMessage.Invoke(new Action(() => tbReceivedMessage.Text += mess + "\r\n"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Thread server;

        private void btListen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                server = new Thread(serverThread);
                server.Start();
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
