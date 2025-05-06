using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            switch (int09.Text)
            {
                case "0":
                    result.Text = "Không";
                    break;
                case "1":
                    result.Text = "Một";
                    break;
                case "2":
                    result.Text = "Hai";
                    break;
                case "3":
                    result.Text = "Ba";
                    break;
                case "4":
                    result.Text = "Bốn";
                    break;
                case "5":
                    result.Text = "Năm";
                    break;
                case "6":
                    result.Text = "Sáu";
                    break;
                case "7":
                    result.Text = "Bảy";
                    break;
                case "8":
                    result.Text = "Tám";
                    break;
                case "9":
                    result.Text = "Chín";
                    break;
                default:
                    MessageBox.Show("Vui lòng nhập số từ 0 đến 9");
                    int09.Focus();
                    break;

            }

        }

        private void advance_Click(object sender, EventArgs e)
        {

            if (intrandom.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                intrandom.Focus();
                return;
            }
            if (!int.TryParse(intrandom.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                intrandom.Focus();
                return;
            }

            int number = int.Parse(intrandom.Text);


            if (number == 0)
            {
                result.Text = "không";
            }
            string[] units = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] levels = { "", "nghìn", "triệu", "tỷ" };
            string rs = "";
            int level = 0;

            while (number > 0)
            {
                int threeDigits = (int)(number % 1000);
                string part = "";
                int hundreds = threeDigits / 100;
                int tens = (threeDigits % 100) / 10;
                int ones = threeDigits % 10;

                // Hàng trăm
                if (hundreds > 0)
                    part += units[hundreds] + " trăm";
                else if (threeDigits > 0 && (tens > 0 || ones > 0)) // Thêm "không trăm" nếu có chục hoặc đơn vị
                    part += "không trăm";

                // Hàng chục và đơn vị
                if (tens > 0)
                {
                    if (part.Length > 0) part += " ";
                    part += (tens == 1) ? "mười" : units[tens] + " mươi";
                    if (ones > 0)
                        part += (ones == 1 && tens > 1) ? " mốt" : (ones == 5) ? " lăm" : " " + units[ones];
                }
                else if (ones > 0)
                {
                    if (part.Length > 0) part += " linh ";
                    part += units[ones];
                }

                // Ghép phần hiện tại với đơn vị cấp độ (nếu có)
                if (threeDigits > 0)
                {
                    part += (level > 0 ? " " + levels[level] : "");
                    rs = (rs.Length > 0 ? part + " " + rs : part);
                }

                number /= 1000;
                level++;
            }
            rs = rs.Trim();
            while (rs.StartsWith("không trăm ") || rs.StartsWith("linh "))
            {
                if (rs.StartsWith("không trăm "))
                    rs = rs.Substring(11); // Bỏ "không trăm " (10 ký tự + 1 khoảng trắng)
                else if (rs.StartsWith("linh "))
                    rs = rs.Substring(5);  // Bỏ "linh " (5 ký tự + 1 khoảng trắng)
                rs = rs.Trim(); // Xóa khoảng trắng thừa sau khi cắt
            }
            result.Text = rs;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            result.Text = "";
            int09.Text = "";
            intrandom.Text = "";
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
