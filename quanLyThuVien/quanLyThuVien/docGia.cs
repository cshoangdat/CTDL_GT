using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyThuVien
{
    class docGia
    {
        private static List<int> usedIds = new List<int>();
        public int MADG;
        public string ho;
        public string ten;
        public string phai;
        public int trangThaiThe;
        public List<string> SachDangMuon;
        public docGia()
        {
            MADG = generateID();
            ho = null;
            ten = null;
            phai = null;
            trangThaiThe = 0;
            SachDangMuon = new List<string>();
        }
        private int generateID()
        {
            int id;
            Random random = new Random();
            do
            {
                id = random.Next(1, 999);
            } while (usedIds.Contains(id));
            usedIds.Add(id);
            return id;
        }
        //private string gender()
        //{
        //    string gender = null;
        //    do
        //    {
        //        Console.Write("Nhap gioi tinh (Nam/Nu): ");
        //        gender = Console.ReadLine();
        //    } while (gender != "Nam" && gender != "Nu" && gender != "nam" && gender != "nu");
        //    return gender;
        //}
        //private int state()
        //{
        //    int state = 0;
        //    do
        //    {
        //        Console.Write("Nhap trang thai the (0/1): ");
        //        state = Convert.ToInt32(Console.ReadLine());
        //    } while (state != 0 && state != 1);
        //    return state;
        //}
        //private string surname()
        //{
        //    string name = null;
        //    Console.Write("Nhap ho cua nguoi doc: ");
        //    name = Console.ReadLine();
        //    return name;
        //}
        //private string name()
        //{
        //    string name = null;
        //    Console.Write("Nhap ten cua nguoi doc: ");
        //    name = Console.ReadLine();
        //    return name;
        //}
    }
}
