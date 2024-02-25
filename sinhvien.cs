using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu2
{
    internal class sinhvien
    {
        string maSinhVien;
        string ten;
        int namSinh;
        double diem;

        public sinhvien()
        {               
        }
        public sinhvien(string maSinhVien, string ten, int namSinh, double diem)
        {
            this.MaSinhVien = maSinhVien;
            this.Ten = ten;
            this.NamSinh = namSinh;
            this.Diem = diem;
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public void inThongTin()
        {
            Console.WriteLine($"{maSinhVien} || {ten} || {NamSinh} || {diem}");
        }
    }
}
