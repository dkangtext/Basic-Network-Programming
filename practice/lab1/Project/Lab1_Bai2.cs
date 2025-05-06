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
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void btFound_Click(object sender, EventArgs e)
        {
            if (tbNumber1.Text == "")
            {
                MessageBox.Show("Please enter the first number!");
                tbNumber1.Focus();
                return;
            }

            if (!double.TryParse(tbNumber1.Text, out _))
            {
                MessageBox.Show("Please enter a valid number!");
                tbNumber1.Focus();
                return;
            }

            if (tbNumber2.Text == "")
            {
                MessageBox.Show("Please enter the second number!");
                tbNumber2.Focus();
                return;
            }

            if (!double.TryParse(tbNumber2.Text, out _))
            {
                MessageBox.Show("Please enter a valid number!");
                tbNumber2.Focus();
                return;
            }

            if (tbNumber3.Text == "")
            {
                MessageBox.Show("Please enter the third number!");
                tbNumber3.Focus();
                return;
            }

            if (!double.TryParse(tbNumber3.Text, out _))
            {
                MessageBox.Show("Please enter a valid number!");
                tbNumber3.Focus();
                return;
            }

            double tbNum1 = double.Parse(tbNumber1.Text);
            double tbNum2 = double.Parse(tbNumber2.Text);
            double tbNum3 = double.Parse(tbNumber3.Text);

            tbMaxNumber.Text = Math.Max(tbNum1, Math.Max(tbNum2, tbNum3)).ToString();
            tbMinNumber.Text = Math.Min(tbNum1, Math.Min(tbNum2, tbNum3)).ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbMinNumber.Text = "";
            tbMaxNumber.Text = "";
            tbNumber1.Text = "";
            tbNumber2.Text = "";
            tbNumber3.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
