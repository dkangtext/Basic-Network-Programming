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
    public partial class Lab3_Bai1_Dashboard : Form
    {
        public Lab3_Bai1_Dashboard()
        {
            InitializeComponent();
        }

        private void btServer_Click(object sender, EventArgs e)
        {
            Lab3_Bai1_U_Server server = new Lab3_Bai1_U_Server();
            server.Show();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            Lab3_Bai1_UDP_Server client = new Lab3_Bai1_UDP_Server();
            client.Show();
        }
    }
}
