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

            Console.Write("Nhap vao ngay ban muon: Ngay = ");
            string ngay = Console.ReadLine();

            Console.Write("Nhap vao thang ban muon: Thang = ");
            string thang = Console.ReadLine();
            
            Console.Write("Nhap vao nam ban muon: Nam = ");
            string nam =Console.ReadLine();

            DateTime date = DateTime.Parse(thang + "/" + ngay + "/" + nam);
                      
         


            Console.WriteLine("Ngay hom qua la: \t{0}",date.AddDays(-1).ToString("dd/mm/yyyy"));
            Console.WriteLine("Ngay hom nay la: \t{0}", date.ToString("dd/mm/yyyy"));
            Console.WriteLine("Ngay hom sau la: \t{0}", date.AddDays(1).ToString("dd/mm/yyyy"));

            Console.WriteLine("<..........................................................>");

           Console.ReadKey();









        }
    }
}
