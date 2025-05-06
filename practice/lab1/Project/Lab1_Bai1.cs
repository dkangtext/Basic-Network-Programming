using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            int tbNum1, tbNum2;

            if (tbNumber1.Text == "")
            {
                MessageBox.Show("Please enter the first number!");
                tbNumber1.Focus();
                return;
            }

            if (!int.TryParse(tbNumber1.Text, out _))
            {
                MessageBox.Show("Please enter a valid number!");
                tbNumber1.Focus();
                return;
            }

            tbNum1 = int.Parse(tbNumber1.Text);

            if (tbNumber2.Text == "")
            {
                MessageBox.Show("Please enter the second number!");
                tbNumber2.Focus();
                return;
            }

            if (!int.TryParse(tbNumber2.Text, out _))
            {
                MessageBox.Show("Please enter a valid number!");
                tbNumber2.Focus();
                return;
            }

            tbNum2 = int.Parse(tbNumber2.Text);

            long tbSum = 0;
            tbSum = tbNum1 + tbNum2;
            tbResult.Text = tbSum.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbNumber1.Text = "";
            tbNumber2.Text = "";
            tbResult.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
