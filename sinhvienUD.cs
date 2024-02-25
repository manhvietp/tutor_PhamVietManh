using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu2
{
    internal class sinhvienUD : sinhvien
    {
        int hocki=2;

        public sinhvienUD()
        {
        }
        public sinhvienUD(string maSinhVien, string ten, int namSinh, double diem,int hocki): base(maSinhVien,ten, namSinh, diem)
        {
            this.Hocki = hocki;
        }

        public int Hocki { get => hocki; set => hocki = value; }
        public void inthongtin()
        {
            base.inThongTin();
            Console.WriteLine("Học kì hiện tai"+ hocki);

        }
    }
}
