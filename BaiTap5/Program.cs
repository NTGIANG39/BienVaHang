using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap5
{
    class ThongTinNhanVien 
    { 
        //Khai báo thuộc tính cho lớp thông tin nhân viên
        public string hoTen { get; set; }
        public string gioiTinh  { get; set;}        
        
        public DateTime ngaySinh { get;set; }   
        public double heSoluong { get; set; }

        public double luongCoban { get; set; }
        public double soNamlamviec { get; set; }
        public double phuCapNhanvien { get; set; }
        public double tamTinh { get; set; }
        public double luong     { get; set; }


        //Lấy thông tin từ thuộc tính đã khai báo
        public ThongTinNhanVien(string hoTen, string gioiTinh, DateTime ngaySinh, double heSoluong, double luongCoban, double soNamlamviec, double phuCapNhanvien)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.heSoluong = heSoluong;
            this.luongCoban = luongCoban;
            this.soNamlamviec = soNamlamviec;
            this.phuCapNhanvien=soNamlamviec >= 5 ? luongCoban /2 : 0;
            this.tamTinh = (double)Math.Ceiling(this.luongCoban * this.heSoluong);
            this.luong = this.tamTinh + this.phuCapNhanvien;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhập thông đầu vào cho nhân viên
            
            ThongTinNhanVien nhanvien1 = new ThongTinNhanVien(
                "Nguyen Van a", "Nam", new DateTime(2023, 03, 20), 2.34,2000,5,1.5);
            
            
            ThongTinNhanVien nhanvien2 = new ThongTinNhanVien(
                "Nguyen Van B", "Nu", new DateTime(2023, 03, 20), 2.34, 4000, 2, 1.5);

            ThongTinNhanVien nhanvien3 = new ThongTinNhanVien(
                "Nguyen Van C", "Nam", new DateTime(2023, 03, 20), 2.34, 6000, 6, 1.5);


            ThongTinNhanVien nhanvien4 = new ThongTinNhanVien(
                "Nguyen Van D", "Nu", new DateTime(2023, 03, 20), 2.34, 8000, 9, 1.5);


            //Xuất thông tin nhân viên 1 ra màn hình
            Console.WriteLine("Nhan vien 1:\n\n{0}\tGioi tinh:{1}\tNgay sinh:{2}\tHe so luong:{3}\tLuong co ban:{4}\tSo " +
                "nam lam viec:{5}\tPhu cap nhan vien:{6}\tTam tinh:{7}\tLuong:{8}", 
                nhanvien1.hoTen,nhanvien1.gioiTinh,nhanvien1.ngaySinh,nhanvien1.heSoluong,
                nhanvien1.luongCoban,nhanvien1.soNamlamviec,nhanvien1.phuCapNhanvien,nhanvien1.tamTinh,nhanvien1.luong);

            //Xuất thông tin nhân viên 2 ra màn hình

            Console.WriteLine("\n\nNhan vien 2:\n\n{0}\tGioi tinh:{1}\tNgay sinh:{2}\tHe so luong:{3}\tLuong co ban:{4}\tSo " +
                            "nam lam viec:{5}\tPhu cap nhan vien:{6}\tTam tinh:{7}\tLuong:{8}",
                            nhanvien2.hoTen, nhanvien2.gioiTinh, nhanvien2.ngaySinh, nhanvien2.heSoluong,
                            nhanvien2.luongCoban, nhanvien2.soNamlamviec, nhanvien2.phuCapNhanvien, nhanvien2.tamTinh, nhanvien2.luong);

            //Xuất thông tin nhân viên 3 ra màn hình
            Console.WriteLine("\n\nNhan vien 3:\n\n{0}\tGioi tinh:{1}\tNgay sinh:{2}\tHe so luong:{3}\tLuong co ban:{4}\tSo " +
                  "nam lam viec:{5}\tPhu cap nhan vien:{6}\tTam tinh:{7}\tLuong:{8}",
                  nhanvien3.hoTen, nhanvien3.gioiTinh, nhanvien3.ngaySinh, nhanvien3.heSoluong,
                  nhanvien3.luongCoban, nhanvien3.soNamlamviec, nhanvien3.phuCapNhanvien, nhanvien3.tamTinh, nhanvien3.luong);

            //Xuất thông tin nhân viên 4 ra màn hình
            Console.WriteLine("\n\nNhan vien 4:\n\n{0}\tGioi tinh:{1}\tNgay sinh:{2}\tHe so luong:{3}\tLuong co ban:{4}\tSo " +
                "nam lam viec:{5}\tPhu cap nhan vien:{6}\tTam tinh:{7}\tLuong:{8}",
                nhanvien4.hoTen, nhanvien4.gioiTinh, nhanvien4.ngaySinh, nhanvien4.heSoluong,
                nhanvien4.luongCoban, nhanvien4.soNamlamviec, nhanvien4.phuCapNhanvien, nhanvien4.tamTinh, nhanvien4.luong);

                      

            Console.ReadKey ();
        }
    }
}
