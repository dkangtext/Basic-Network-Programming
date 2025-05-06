using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            result.Text = "";
            to.Text = "";
            from.Text = "";
            input.Text = "";
        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (to.Text !=  "" || from.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }

            if (to.Text == "Binary")
            {
                foreach (char c in input.Text)
                {
                    if (c != '0' && c != '1')
                    {
                        MessageBox.Show("Vui lòng nhập số Binary");
                        return;
                    }
                }
            }
            else if (to.Text == "Decimal" && !int.TryParse(input.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số thập phân");
            }
            else if (to.Text == "Hexadecimal" && !int.TryParse(input.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("Vui lòng nhập số thập lục phân");
            }


            if (from.Text == "Binary" && to.Text == "Decimal")
            {
                result.Text = Convert.ToInt32(input.Text, 2).ToString();
            }
            else if (from.Text == "Binary" && to.Text == "Hexadecimal")
            {
                result.Text = Convert.ToInt32(input.Text, 2).ToString("X");
            }
            else if (from.Text == "Decimal" && to.Text == "Binary")
            {
                result.Text = Convert.ToString(int.Parse(input.Text), 2);
            }
            else if (from.Text == "Decimal" && to.Text == "Hexadecimal")
            {
                result.Text = int.Parse(input.Text).ToString("X");
            }
            else if (from.Text == "Hexadecimal" && to.Text == "Binary")
            {
                result.Text = Convert.ToString(Convert.ToInt32(input.Text, 16), 2);
            }
            else if (from.Text == "Hexadecimal" && to.Text == "Decimal")
            {
                result.Text = Convert.ToInt32(input.Text, 16).ToString();
            }
            else if (from.Text == to.Text)
            {
                result.Text = input.Text;
            }
        }
    }
}
