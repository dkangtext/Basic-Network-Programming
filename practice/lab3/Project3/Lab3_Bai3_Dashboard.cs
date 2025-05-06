using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Lab3_Bai3_Dashboard : Form
    {
        public Lab3_Bai3_Dashboard()
        {
            InitializeComponent();
        }

        private void btTCPClient_Click(object sender, EventArgs e)
        {
            Lab3_Bai3_TCP_Client lab3_Bai3_TCP_Client = new Lab3_Bai3_TCP_Client();
            lab3_Bai3_TCP_Client.Show();
        }

        private void btTCPServer_Click(object sender, EventArgs e)
        {
            Lab3_Bai3 lab3_Bai3 = new Lab3_Bai3();
            lab3_Bai3.Show();
        }
    }
}
