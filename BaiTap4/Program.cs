using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Ho ten sinh vien: ");
            string hoTen = Console.ReadLine();

            Console.WriteLine("Nhap Lop cua sinh vien: ");
            string lop = Console.ReadLine();

            Console.WriteLine("Nhap diem trung binh HKI: ");
            decimal diemTrungbinhHKI = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem trung binh HKII: ");
            decimal diemTrungbinhHKII = decimal.Parse(Console.ReadLine());

            //Công thức tính điêm trung bình cả năm của học sinh

           decimal diemTrungBinhcanam = (decimal)(diemTrungbinhHKI + (diemTrungbinhHKII*2))/3;
            

            Console.WriteLine("Diem trung binh ca nam cua hoc sinh la: \t {0}",diemTrungBinhcanam);

            Console.ReadKey();

        }
    }
}
