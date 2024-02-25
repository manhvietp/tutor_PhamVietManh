using System.Text;

namespace thu2
{// 45-35
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            sinhvienService sv = new sinhvienService();
            do
            {
                switch (Menu())
                {
                    case "1":
                        sv.NhapDS();
                        break;
                    case "2":
                        sv.xuatDS();
                        break;
                    case "3":
                        sv.DSVeVip();
                        break;
                    case "4":
                        sv.XoaDSKhongthamgia();
                        break;
                    case "5":
                        sinhvienUD svud=new sinhvienUD();
                        svud.MaSinhVien = "1";
                        svud.Ten = "mạnh";
                        svud.NamSinh = 2005;
                        svud.Diem = 8;
                        svud.inthongtin();


                        break;
                    case "0":
                        return;
                }

            } while (true) ;


            
        }

        static string Menu()
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("1.Nhập đối tượng.");
            Console.WriteLine("2.Xuất đối tượng.");
            Console.WriteLine("3.Danh sách vé vip.");
            Console.WriteLine("4.Xóa người không có vé.");
            Console.WriteLine("5.kế thừa");
            Console.WriteLine("0.Thoát.");
            Console.WriteLine("Xin mời chọn:");
            string choose = Console.ReadLine();
            if (choose != "1" && choose != "2" && choose != "3" && choose != "4" && choose != "5" && choose != "0") Menu();
            return choose;

        }
    }
}
