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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string diem = input.Text;
            string[] diemthanhphan = diem.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (diemthanhphan.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập 12 điểm");
                return;
            }

            for (int i = 0; i < diemthanhphan.Length; i++)
            {
                if (double.Parse(diemthanhphan[i]) < 0 || double.Parse(diemthanhphan[i]) > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ, vui lòng nhập lại");
                    return;
                }
            }

            double[] diemso = new double[diemthanhphan.Length];
            int countDau = 0;
            int countRot = 0;
            for (int i = 0; i < diemthanhphan.Length; i++)
            {
                diemso[i] = double.Parse(diemthanhphan[i]);
                if (diemso[i] >= 5)
                {
                    countDau++;
                }
                else
                {
                    countRot++;
                }
            }

            Mon1.Text = "Môn 1: " + diemso[0].ToString() + "đ";
            Mon2.Text = "Môn 2: " + diemso[1].ToString() + "đ";
            Mon3.Text = "Môn 3: " + diemso[2].ToString() + "đ";
            Mon4.Text = "Môn 4: " + diemso[3].ToString() + "đ";
            Mon5.Text = "Môn 5: " + diemso[4].ToString() + "đ";
            Mon6.Text = "Môn 6: " + diemso[5].ToString() + "đ";
            Mon7.Text = "Môn 7: " + diemso[6].ToString() + "đ";
            Mon8.Text = "Môn 8: " + diemso[7].ToString() + "đ";
            Mon9.Text = "Môn 9: " + diemso[8].ToString() + "đ";
            Mon10.Text = "Môn 10: " + diemso[9].ToString() + "đ";
            Mon11.Text = "Môn 11: " + diemso[10].ToString() + "đ";
            Mon12.Text = "Môn 12: " + diemso[11].ToString() + "đ";

            double diemtong = 0;
            for (int i = 0; i < diemso.Length; i++)
            {
                diemtong += diemso[i];
            }

            double diemtrungbinh = diemtong / diemso.Length;

            DTB.Text = "Điểm trung bình: " + diemtrungbinh.ToString() + "đ";

            int maxDiem = 0;

            int minDiem = 0;

            for (int i = 0; i < diemso.Length; i++)
            {
                if (diemso[i] > diemso[maxDiem])
                {
                    maxDiem = i;
                }
                if (diemso[i] < diemso[minDiem])
                {
                    minDiem = i;
                }
            }

            maxD.Text = "Điểm cao nhất: " + diemso[maxDiem].ToString() + "đ";
            minD.Text = "Điểm thấp nhất: " + diemso[minDiem].ToString() + "đ";
            Pass.Text = "Số môn đậu: " + countDau.ToString();
            Fail.Text = "Số môn rớt: " + countRot.ToString();

            if (diemtrungbinh >= 8 && diemso[minDiem] >= 6.5)
            {
                HL.Text = "Xếp loại học lực: Giỏi";
            }
            else if (diemtrungbinh >= 6.5 && diemso[minDiem] >= 5)
            {
                HL.Text = "Xếp loại học lực: Khá";
            }
            else if (diemtrungbinh >= 5 && diemso[minDiem] >= 3.5)
            {
                HL.Text = "Xếp loại học lực: TB";
            }
            else if (diemtrungbinh >= 3.5 && diemso[minDiem] >= 2)
            {
                HL.Text = "Xếp loại học lực: Yếu";
            }
            else
            {
                HL.Text = "Xếp loại học lực: Kém";
            }
        }
    }
}
