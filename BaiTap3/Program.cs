using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap duong kinh hinh tron: ");
            int duongKinh = int.Parse(Console.ReadLine());
            
            double chuVi = (double) duongKinh  * 3.14;

            double banKinh = (double) chuVi / (2 * 3.14);

            double dienTich = (double)banKinh * 2 * 3.14;

            Console.WriteLine("Chu vi hinh tron la:      \t {0}", chuVi);
            Console.WriteLine("Ban kinh hinh tron la:    \t {0}", banKinh);
            Console.WriteLine("Dien tich hinh tron la:\t {0}", dienTich);
            Console.ReadKey();


        }
    }
}
