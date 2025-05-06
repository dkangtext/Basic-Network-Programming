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
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void btBasicRead_Click(object sender, EventArgs e)
        {
            switch (tbRead1.Text)
            {
                case "0":
                    tbResult.Text = "Không";
                    break;

                case "1":
                    tbResult.Text = "Một";
                    break;

                case "2":
                    tbResult.Text = "Hai";
                    break;

                case "3":
                    tbResult.Text = "Ba";
                    break;

                case "4":
                    tbResult.Text = "Bốn";
                    break;

                case "5":
                    tbResult.Text = "Năm";
                    break;

                case "6":
                    tbResult.Text = "Sáu";
                    break;

                case "7":
                    tbResult.Text = "Bảy";
                    break;

                case "8":
                    tbResult.Text = "Tám";
                    break;

                case "9":
                    tbResult.Text = "Chín";
                    break;

                default:
                    MessageBox.Show("Please enter a number from 0 to 9");
                    tbResult.Focus();
                    break;

            }
        }

        private void btAdvancedRead_Click(object sender, EventArgs e)
        {
            if (tbRead2.Text == "")
            {
                MessageBox.Show("Please enter a positive number");
                tbRead2.Focus();
                return;
            }

            if (!int.TryParse(tbRead2.Text, out _))
            {
                MessageBox.Show("Please enter a positive number");
                tbRead2.Focus();
                return;
            }

            int Number = int.Parse(tbRead2.Text);

            if (Number == 0)
            {
                tbResult.Text = "Không";
                return;
            }

            string[] Units = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] Levels = { "", "Nghìn", "Triệu", "Tỷ" };

            string Result = "";
            int Level = 0;

            while (Number > 0)
            {
                int ThreeDigits = (int)(Number % 1000);
                string ThreeDigitsString = "";
                int Hundreds = ThreeDigits / 100;
                int Tens = (ThreeDigits % 100) / 10;
                int Unit = ThreeDigits % 10;

                // Process Hundreds
                if (Hundreds > 0)
                {
                    ThreeDigitsString += Units[Hundreds] + " Trăm ";
                }
                else if (ThreeDigits > 0 && (Tens > 0 || Unit > 0))
                {
                    ThreeDigitsString += "Không Trăm ";
                }

                // Process Tens and Unit
                if (Tens > 0)
                {
                    if (ThreeDigitsString.Length > 0)
                    {
                        ThreeDigitsString += " ";
                    }
                    ThreeDigitsString += (Tens == 1) ? "Mười" : Units[Tens] + " Mươi";

                    if (Unit > 0)
                    {
                        ThreeDigitsString += (Unit == 1 && Tens > 1) ? " Mốt" : (Unit == 5 && Tens == 1) ? " Lăm" : " " + Units[Unit];
                    }
                }
                else if (Unit > 0)
                {
                    if (ThreeDigitsString.Length > 0)
                    {
                        ThreeDigitsString += "Linh ";
                    }
                    ThreeDigitsString += Units[Unit];
                }

                // Add Level
                if (ThreeDigits > 0)
                {
                    ThreeDigitsString += (Level > 0 ? " " + Levels[Level] : "");
                    Result = (Result.Length > 0 ? ThreeDigitsString + " " + Result : ThreeDigitsString);
                }

                Number /= 1000;
                Level++;
            }

            Result = Result.Trim();

            // Loại bỏ các trường hợp không cần thiết ở đầu chuỗi
            while (Result.StartsWith("Không Trăm") || Result.StartsWith("Linh"))
            {
                if (Result.StartsWith("Không Trăm "))
                {
                    Result = Result.Substring(11);
                }
                else if (Result.StartsWith("Linh "))
                {
                    Result = Result.Substring(5);
                }
                Result = Result.Trim();
            }

            tbResult.Text = Result;

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            tbRead1.Text = "";
            tbRead2.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
