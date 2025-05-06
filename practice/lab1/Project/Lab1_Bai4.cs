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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void btDo_Click(object sender, EventArgs e)
        {
            if (cbChoose.Text == "" || cbInto.Text == "")
            {
                MessageBox.Show("Please choose the number system and the number to convert to!");
                return;
            }    

            if (cbChoose.Text == "Binary")
            {
                foreach (char c in tbNumber.Text)
                {
                    if (c != '0' && c != '1')
                    {
                        MessageBox.Show("Please enter a binary number (Only 0 and 1)!");
                        tbNumber.Focus();
                        return;
                    }
                }
            }
            else if (cbChoose.Text == "Decimal")
            { 
                if (!int.TryParse(tbNumber.Text, out _))
                {
                    MessageBox.Show("Please enter a decimal number!");
                    tbNumber.Focus();
                    return;
                }

                if (int.Parse(tbNumber.Text) < 0)
                {
                    MessageBox.Show("Please enter a positive decimal number!");
                    tbNumber.Focus();
                    return;
                }
            }
            else if (cbChoose.Text == "Hexadecimal")
            {
                string hexInput = tbNumber.Text.ToUpper();
                foreach (char c in hexInput)
                {
                    if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                    {
                        MessageBox.Show("Please enter a hexadecimal number (0-9, A-F)!");
                        tbNumber.Focus();
                        return;
                    }
                }
            }

            try
            {
                if (cbChoose.Text == "Binary" && cbInto.Text == "Decimal")
                {
                    tbResult.Text = Convert.ToInt32(tbNumber.Text, 2).ToString();
                }
                else if (cbChoose.Text == "Binary" && cbInto.Text == "Hexadecimal")
                {
                    tbResult.Text = Convert.ToInt32(tbNumber.Text, 2).ToString("X");
                }
                else if (cbChoose.Text == "Decimal" && cbInto.Text == "Binary")
                {
                    tbResult.Text = Convert.ToString(int.Parse(tbNumber.Text), 2);
                }
                else if (cbChoose.Text == "Decimal" && cbInto.Text == "Hexadecimal")
                {
                    tbResult.Text = int.Parse(tbNumber.Text).ToString("X");
                }
                else if (cbChoose.Text == "Hexadecimal" && cbInto.Text == "Binary")
                {
                    tbResult.Text = Convert.ToString(Convert.ToInt32(tbNumber.Text, 16), 2);
                }
                else if (cbChoose.Text == "Hexadecimal" && cbInto.Text == "Decimal")
                {
                    tbResult.Text = Convert.ToInt32(tbNumber.Text, 16).ToString();
                }
                else if (cbChoose.Text == cbInto.Text)
                {
                    tbResult.Text = tbNumber.Text;
                }
            }    
            catch (FormatException)
            {
                MessageBox.Show("Invalid input!");
                tbNumber.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too large!");
                tbNumber.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbNumber.Focus();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbNumber.Text = "";
            cbChoose.Text = "";
            cbInto.Text = "";
            tbResult.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
