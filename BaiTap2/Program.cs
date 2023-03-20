using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap chieu dai cua hinh chu nhat:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chieu rong cua hinh chu nhat:");
            int b = int.Parse(Console.ReadLine());

            int chuVi = (a + b)*2;
            int dienTich = a * b;

            Console.WriteLine("Chu vi hinh chu nhat la: \t {0}", chuVi);
            Console.WriteLine("Dien tich hinh chu nhat la: \t {0}", dienTich);
        }
    }
}
