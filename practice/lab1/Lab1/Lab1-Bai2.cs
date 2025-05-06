using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab1_Bai2_Load(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (bai2So1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất");
                bai2So1.Focus();
                return;
            }

            if (bai2So2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thứ hai");
                bai2So2.Focus();
                return;
            }

            if (bai2So3.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thứ ba");
                bai2So3.Focus();
                return;
            }

            if (!double.TryParse(bai2So1.Text, out _))
            {
                MessageBox.Show("Số thứ nhất sai kiểu dữ liệu");
                bai2So1.Focus();
                return;
            }

            if (!double.TryParse(bai2So2.Text, out _))
            {
                MessageBox.Show("Số thứ hai sai kiểu dữ liệu");
                bai2So2.Focus();
                return;
            }

            if (!double.TryParse(bai2So3.Text, out _))
            {
                MessageBox.Show("Số thứ ba sai kiểu dữ liệu");
                bai2So3.Focus();
                return;
            }


            double num1 = double.Parse(bai2So1.Text);
            double num2 = double.Parse(bai2So2.Text);
            double num3 = double.Parse(bai2So3.Text);
            maxNumber.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
            minNumber.Text = Math.Min(Math.Min(num1, num2), num3).ToString();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            minNumber.Text = "";
            maxNumber.Text = "";
            bai2So1.Text = "";
            bai2So2.Text = "";
            bai2So3.Text = "";
        }
    }
}
