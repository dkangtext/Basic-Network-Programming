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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void btPrint_Click_1(object sender, EventArgs e)
        {
            string Diem = tbMarksList.Text;

            string[] DiemThanhPhan = Diem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (DiemThanhPhan.Length != 12)
            {
                MessageBox.Show("Please enter 12 marks!");
                tbMarksList.Focus();
                return;
            }

            for (int i = 0; i < DiemThanhPhan.Length; i++)
            {
                if (double.Parse(DiemThanhPhan[i]) < 0 || double.Parse(DiemThanhPhan[i]) > 10)
                {
                    MessageBox.Show("Please enter marks from 0 to 10!");
                    tbMarksList.Focus();
                    return;
                }
            }

            double[] DiemSo = new double[DiemThanhPhan.Length];
            int CountPass = 0;
            int CountFail = 0;

            for (int i = 0; i < DiemThanhPhan.Length; i++)
            {
                DiemSo[i] = double.Parse(DiemThanhPhan[i]);
                if (DiemSo[i] >= 5)
                {
                    CountPass++;
                }
                else
                {
                    CountFail++;
                }
            }

            Subject1.Text = "Môn 1: " + DiemSo[0].ToString() + "đ";
            Subject2.Text = "Môn 2: " + DiemSo[1].ToString() + "đ";
            Subject3.Text = "Môn 3: " + DiemSo[2].ToString() + "đ";
            Subject4.Text = "Môn 4: " + DiemSo[3].ToString() + "đ";
            Subject5.Text = "Môn 5: " + DiemSo[4].ToString() + "đ";
            Subject6.Text = "Môn 6: " + DiemSo[5].ToString() + "đ";
            Subject7.Text = "Môn 7: " + DiemSo[6].ToString() + "đ";
            Subject8.Text = "Môn 8: " + DiemSo[7].ToString() + "đ";
            Subject9.Text = "Môn 9: " + DiemSo[8].ToString() + "đ";
            Subject10.Text = "Môn 10: " + DiemSo[9].ToString() + "đ";
            Subject11.Text = "Môn 11: " + DiemSo[10].ToString() + "đ";
            Subject12.Text = "Môn 12: " + DiemSo[11].ToString() + "đ";

            Double DiemTong = 0;

            for (int i = 0; i < DiemSo.Length; i++)
            {
                DiemTong += DiemSo[i];
            }

            double DiemTrungBinh = DiemTong / DiemSo.Length;

            Average.Text = "Điểm trung bình: " + DiemTrungBinh.ToString() + "đ";

            int DiemMax = 0;

            int DiemMin = 0;

            for (int i = 0; i < DiemSo.Length; i++)
            {
                if (DiemSo[i] > DiemSo[DiemMax])
                {
                    DiemMax = i;
                }
                if (DiemSo[i] < DiemSo[DiemMin])
                {
                    DiemMin = i;
                }
            }

            Max.Text = "Điểm cao nhất: " + DiemSo[DiemMax].ToString() + "đ";

            Min.Text = "Điểm thấp nhất: " + DiemSo[DiemMin].ToString() + "đ";

            Pass.Text = "Số môn đậu: " + CountPass.ToString();

            Fail.Text = "Số môn rớt: " + CountFail.ToString();

            if (DiemTrungBinh >= 8 && DiemSo[DiemMin] >= 6.5)
            {
                Level.Text = "Xếp loại học lực: Giỏi";
            }
            else if (DiemTrungBinh >= 6.5 && DiemSo[DiemMin] >= 5)
            {
                Level.Text = "Xếp loại học lực: Khá";
            }
            else if (DiemTrungBinh >= 5 && DiemSo[DiemMin] >= 3.5)
            {
                Level.Text = "Xếp loại học lực: Trung bình";
            }
            else if (DiemTrungBinh >= 3.5 && DiemSo[DiemMin] >= 2)
            {
                Level.Text = "Xếp loại học lực: Yếu";
            }
            else
            {
                Level.Text = "Xếp loại học lực: Kém";
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            tbMarksList.Text = "";
            Subject1.Text = "Môn 1: ";
            Subject2.Text = "Môn 2: ";
            Subject3.Text = "Môn 3: ";
            Subject4.Text = "Môn 4: ";
            Subject5.Text = "Môn 5: ";
            Subject6.Text = "Môn 6: ";
            Subject7.Text = "Môn 7: ";
            Subject8.Text = "Môn 8: ";
            Subject9.Text = "Môn 9: ";
            Subject10.Text = "Môn 10: ";
            Subject11.Text = "Môn 11: ";
            Subject12.Text = "Môn 12: ";
            Average.Text = "Điểm trung bình: ";
            Max.Text = "Điểm cao nhất: ";
            Min.Text = "Điểm thấp nhất: ";
            Pass.Text = "Số môn đậu: ";
            Fail.Text = "Số môn rớt: ";
            Level.Text = "Xếp loại học lực: ";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
