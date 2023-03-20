using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai báo biến
            Console.WriteLine("Moi ban nhap so nguyen duong a:  ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Moi ban nhap so nguyen duong b: ");
            int b = int.Parse(Console.ReadLine());

            //hàm tính toán
            int tong = a + b;
            int tich = a * b;
            float  hieu = (float)a / b;

            //Xuat ket quả
            Console.WriteLine("Tong cua so nguyen duong a va b la: \t {0}",tong);
            Console.WriteLine("Tich cua so nguyen duong a va b la: \t {0}", tich);
            Console.WriteLine("Tong cua so nguyen duong a va b la: \t {0}", hieu);
            Console.ReadKey();
        }
    }
}
