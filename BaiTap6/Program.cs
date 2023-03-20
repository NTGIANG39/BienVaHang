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

            int ngay = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang ban muon: Thang = ");
            int thang = Int32.Parse(Console.ReadLine());
            
            Console.Write("Nhap vao nam ban muon: Nam = ");
            int nam = Int32.Parse(Console.ReadLine());

           
            DateTime date = new DateTime(nam,thang,ngay);
            Console.WriteLine(date.DayOfWeek);

            Console.WriteLine("<..........................................................>");

           









        }
    }
}
