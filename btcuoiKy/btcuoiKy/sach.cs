using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btcuoiKy
{
    class sach
    {
        public string ISBN;
        public string tenSach;
        public int soTrang;
        public string tacGia;
        public int namXB;
        public string theLoai;
        public sach next;

        public int maSach;
        public int trangThaiSach;
        public int viTri;

        public sach()
        {
            ISBN = isbn_write();
            tenSach = tenSach_write();
            soTrang = soTrang_write();
            tacGia = tacGia_write();
            namXB = namXB_write();
            theLoai = theloai_write();
            next = null;
            maSach = 0;
            trangThaiSach = trangThaiSach_write();
            viTri = 0;
        }
        private string isbn_write()
        {
            string a = null;
            Console.Write("Nhap ISBN cua cuon sach: ");
            a = Console.ReadLine();
            return a;
        }
        private string tenSach_write()
        {
            string a = null;
            Console.Write("Nhap ten sach: ");
            a = Console.ReadLine();
            return a;
        }
        private int soTrang_write()
        {
            int a = 0;
            Console.Write("Nhap so trang: ");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        private string tacGia_write()
        {
            string a = null;
            Console.Write("Nhap ten tac gia: ");
            a = Console.ReadLine();
            return a;
        }
        private int namXB_write()
        {
            int a = 0;
            Console.Write("Nhap nam xuat ban: ");
            a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        private string theloai_write()
        {
            string a = null;
            Console.Write("Nhap the loai: ");
            a = Console.ReadLine();
            return a;
        }
        private int trangThaiSach_write()
        {
            int a;
            do
            {
                Console.Write("Nhap trang thai sach (0/1/2): ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 0 && a != 1 && a!= 2);
            return a;
        }
    }
}
