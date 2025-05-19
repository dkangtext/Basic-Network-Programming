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
    public partial class Lab3_Bai2 : Form
    {
        public Lab3_Bai2()
        {
            InitializeComponent();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        void StartUnsafeThread()
        {
            try
            {
                lvListen.Items.Add(new ListViewItem("Waiting for connection..."));

                Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

      
                listenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(10); 

                btListen.Text = "Listening";

                while (true) 
                {
                    Socket clientSocket = listenerSocket.Accept();
                    lvListen.Items.Add(new ListViewItem("Telnet connected on " + ipepServer.Address + ":" + ipepServer.Port));

                    Thread clientThread = new Thread(() =>
                    {
                        try
                        {
                            int bytesReceived;
                            byte[] recv = new byte[1];
                            string text = "";

                            while (clientSocket.Connected)
                            {
                                bytesReceived = clientSocket.Receive(recv);
                                if (bytesReceived == 0) break;

                                text += Encoding.UTF8.GetString(recv, 0, bytesReceived);
                                if (text.EndsWith("\n"))
                                {
                                    lvListen.Items.Add(new ListViewItem(ipepServer.Address + ":" + ipepServer.Port + ": " + text.Trim()));
                                    text = "";
                                }
                            }

                            lvListen.Items.Add(new ListViewItem("Connection closed."));
                            clientSocket.Close();
                        }
                        catch (Exception ex)
                        {
                            lvListen.Items.Add(new ListViewItem("Client error: " + ex.Message));
                        }
                    });
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server error: " + ex.Message);
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvListen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
