using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu2
{
    internal class sinhvienService
    {
        List<sinhvien> listSinhVien;
        public sinhvienService()
        {
            listSinhVien= new List<sinhvien>();
        }


        public void NhapDS()
        {
            Console.WriteLine("Xin mời nhập số sinh viên:");
            int sl = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine($"Xin mời nhập sinh viên thứ {i + 1}");
                sinhvien sv = new sinhvien();
                Console.WriteLine("Xin mời nhập mã sinh viên: ");
                sv.MaSinhVien = Console.ReadLine();
                Console.WriteLine("Xin mời nhập tên:");
                sv.Ten = Console.ReadLine();
                Console.WriteLine("Xin mời nhập năm sinh:");
                sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Xin mời nhập điểm:");
                sv.Diem = Convert.ToDouble(Console.ReadLine());
                listSinhVien.Add(sv);

            }
            Console.WriteLine("bạn có muốn nhập tiếp hay không?Nhấn Y/y để tiếp tục, còn lại là không!!");
            string chon = Console.ReadLine();
            if (chon == "y" || chon == "Y") NhapDS();
        }

        public bool kiemTra()
        {
            if(listSinhVien.Count==0)
            {
                Console.WriteLine("Danh sách trống");
                return false;
            }
            return true;
        }
        public void xuatDS()
        {        
            while(kiemTra())
            {
                foreach (var item in listSinhVien)
                    {
                        item.inThongTin();
                    }
                break;
            }
            
        }

        public void DSVeVip()
        {
            while (kiemTra())
            {
                foreach(var item in listSinhVien)
                    {
                        if (item.Diem >= 8)
                        {
                            item.inThongTin();
                        }
                    }
                break;
            }
            
        }

        public void XoaDSKhongthamgia()
        {
            while (kiemTra())
            {
                foreach (var item in listSinhVien.ToList())
                {
                    if ((DateTime.Now.Year - item.NamSinh) > 25 && item.Diem < 8)
                    {
                        listSinhVien.Remove(item);
                    }
                    item.inThongTin();
                }
                break;
            }
        }
    }
}
