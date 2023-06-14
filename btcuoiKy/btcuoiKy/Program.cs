using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btcuoiKy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sach: ");
            int num = Convert.ToInt32(Console.ReadLine());
            dauSach dauSach = new dauSach(num);
            dauSach.themSach(new sach());
            dauSach.themSach(new sach());
            dauSach.themSach(new sach());
            dauSach.hienThiDS();
            dauSach.themSach(new sach());



            //danhMucSach danhMucSach = new danhMucSach();
            //danhMucSach.themSach(new sach() { maSach = 1, trangThaiSach = 0, viTri = 1 });
            //danhMucSach.themSach(new sach() { maSach = 2, trangThaiSach = 1, viTri = 2 });
            //danhMucSach.themSach(new sach() { maSach = 3, trangThaiSach = 2, viTri = 3 });
            //danhMucSach.themSach(new sach() { maSach = 4, trangThaiSach = 1, viTri = 4 });
            //danhMucSach.hienThiDanhMuc();


            danhSachDocGia danhSachDocGia = new danhSachDocGia();

            // Thêm đọc giả vào danh sách
            danhSachDocGia.themDocGia(new docGia());
            danhSachDocGia.themDocGia(new docGia());
            danhSachDocGia.themDocGia(new docGia());
            // Hiển thị danh sách đọc giả
            danhSachDocGia.hienThiDanhSachDocGia_inorder();
            Console.WriteLine();
            //danhSachDocGia.xoaDocGia(4);
            //danhSachDocGia.hienThiDanhSachDocGia();
            //danhSachDocGia.themDocGia(new docGia());
            //danhSachDocGia.themDocGia(new docGia());
            //danhSachDocGia.hienThiDanhSachDocGia_preorder();
            //Console.WriteLine();
            //Console.WriteLine();
            //danhSachDocGia.hieuChinhDocGia(2, new docGia() { MADG = 7, ho = "Hoang", ten = "Thanh A", phai = "Nam", trangThaiThe = 3 });
            //danhSachDocGia.hienThiDanhSachDocGia();
        }
    }
}
