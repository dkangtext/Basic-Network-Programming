using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien 
{
    internal class SinhVien
    {
        private string MSSV;
        private string HoTen;
        private double DiemMon1;
        private double DiemMon2;
        private double DiemMon3;

        public void setHoTen(string HoTen)
        {
            this.HoTen = HoTen;
        }
        public string getHoTen()
        {
            return HoTen;
        }

        public void setDiemMon1(double DiemMon1)
        {
            this.DiemMon1 = DiemMon1;
        }

        public double getDiemMon1()
        {
            return DiemMon1;
        }

        public void setDiemMon2(double DiemMon2)
        {
            this.DiemMon2 = DiemMon2;
        }

        public double getDiemMon2()
        {
            return DiemMon2;
        }

        public void setDiemMon3(double DiemMon3)
        {
            this.DiemMon3 = DiemMon3;
        }

        public double getDiemMon3()
        {
            return DiemMon3;
        }

        public void setMSSV(string MSSV)
        {
            this.MSSV = MSSV;
        }

        public string getMSSV()
        {
            return MSSV;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap MSSV: ");
            MSSV = Console.ReadLine();
            
            Console.WriteLine("---- Nhap diem 3 mon ----");
            
            Console.Write("Nhap diem mon dai cuong: ");
            DiemMon1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem mon chuyen nganh MMTT: ");
            DiemMon2 = double.Parse(Console.ReadLine());
            
            Console.Write("Nhap diem mon chuyen nganh ANTT: ");
            DiemMon3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thong tin sinh vien");
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("MSSV: " + MSSV);
            Console.WriteLine("Diem trung binh: " + (DiemMon1 + DiemMon2 + DiemMon3) / 3);
            Console.WriteLine();
        }
    }

    internal class SVMMTT : SinhVien
    {
        public override void Xuat()
        {
            Console.WriteLine("Thong tin sinh vien MMTT");
            Console.WriteLine("Ho ten: " + getHoTen());
            Console.WriteLine("MSSV: " + getMSSV());
            Console.WriteLine("Diem trung binh: " + (getDiemMon1() + getDiemMon2() * 2 + getDiemMon3()) / 4);
            Console.WriteLine();
        }
    }

    internal class SVANTT : SinhVien
    {
        public override void Xuat()
        {
            Console.WriteLine("Thong tin sinh vien ANTT");
            Console.WriteLine("Ho ten: " + getHoTen());
            Console.WriteLine("MSSV: " + getMSSV());
            Console.WriteLine("Diem trung binh: " + (getDiemMon1() + getDiemMon2() + getDiemMon3() * 2)/ 4);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien a;
            a = new SinhVien();
            a.Nhap();
            a.Xuat();

            SinhVien b;
            b = new SVMMTT();
            b.Nhap();
            b.Xuat();

            SinhVien c;
            c = new SVANTT();
            c.Nhap();
            c.Xuat();
        }
    }
}
