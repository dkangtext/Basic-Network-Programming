using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Lab4_Controls : Form
    {
        public Lab4_Controls()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Lab4_Bai1 bai1 = new Lab4_Bai1();
            bai1.Show();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Lab4_Bai2 bai2 = new Lab4_Bai2();
            bai2.Show();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Lab4_Bai3 bai3 = new Lab4_Bai3();
            bai3.Show();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Lab4_Bai4 bai4 = new Lab4_Bai4();
            bai4.Show();
        }
    }
}
