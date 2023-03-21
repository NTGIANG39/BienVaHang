using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("Nhap vao ngay ban muon: Ngay = ");
            // string day = Console.ReadLine();

            // Console.Write("Nhap vao thang ban muon: Thang = ");
            // string month = Console.ReadLine();

            // Console.Write("Nhap vao nam ban muon: Nam = ");
            // string year =Console.ReadLine();


            // DateTime date = DateTime.Parse(day + "/" + month + "/" + year);




            // Console.WriteLine("Ngay hom qua la: \t{0}", date.AddDays(-1).ToString("dd/mm/yyyy"));
            // Console.WriteLine("Ngay hom nay la: \t{0}", date.ToString("dd/mm/yyyy"));
            // Console.WriteLine("Ngay hom sau la: \t{0}", date.AddDays(1).ToString("dd/mm/yyyy"));

            // Console.WriteLine("<..........................................................>");

            //Console.ReadKey();


            Console.Write("Nhap vao ngay ban muon: Ngay = ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ngay hom qua la: \t{0}", date.AddDays(-1));
            Console.WriteLine("Ngay hom nay la: \t{0}", date);
            Console.WriteLine("Ngay hom sau la: \t{0}", date.AddDays(1));

            Console.WriteLine("<..........................................................>");

            Console.ReadKey();






        }
    }
}
