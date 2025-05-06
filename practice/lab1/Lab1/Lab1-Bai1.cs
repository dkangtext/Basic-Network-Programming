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
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number_1.Text = "";
            number_2.Text = "";
            ResultSum.Text = "";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (number_1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên thứ nhất");
                number_1.Focus();
                return;
            }
            if (!int.TryParse(number_1.Text,out _))
            {
                MessageBox.Show("Số thứ nhất sai kiểu dữ liệu");
                number_1.Focus();
                return;
            }    
            num1 = Int32.Parse(number_1.Text);


            if (number_2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên thứ hai");
                number_2.Focus();
                return;
            }
            if (!int.TryParse(number_2.Text, out _))
            {
                MessageBox.Show("Số thứ hai sai kiểu dữ liệu");
                number_2.Focus();
                return;
            }
            num2 = Int32.Parse(number_2.Text);
            sum = num1 + num2;
            ResultSum.Text = sum.ToString();

        }

        private void number_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultSum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
