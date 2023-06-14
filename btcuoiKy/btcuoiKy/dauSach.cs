using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btcuoiKy
{
    class dauSach
    {
        private static int nextmaSach = 0;
        public sach[] dsSach;
        public int soLuongSach;
        public dauSach(int soLuongSach)
        {
            dsSach = new sach[soLuongSach];
            soLuongSach = 0;
        }
        public void themSach(sach sach)
        {
            sach.maSach = nextmaSach;
            nextmaSach++;
            dsSach[soLuongSach] = sach;
            soLuongSach++;
        }
        public void hienThiDS()
        {
            sapXepTangDan();
            for (int i = 0; i< soLuongSach; i++)
            {
                Console.Write(dsSach[i].ISBN + " " + dsSach[i].maSach + " " + dsSach[i].namXB + " " + dsSach[i].soTrang + " " + dsSach[i].tacGia + " " + dsSach[i].tenSach + " " + dsSach[i].theLoai + " " + dsSach[i].trangThaiSach);
                Console.WriteLine();
            }
        }
        private void sapXepTangDan()
        {
            for(int i = 0; i < soLuongSach; i++)
            {
                for(int j = soLuongSach - 1; j > i; j--)
                {
                    if( dsSach[j].tenSach[0].CompareTo(dsSach[j-1].tenSach[0]) < 0)
                    {
                        sach temp = dsSach[j];
                        dsSach[j] = dsSach[j - 1];
                        dsSach[j - 1] = temp;
                    }
                }
            }
        }
    }
}
