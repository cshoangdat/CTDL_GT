using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyThuVien
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
        public void hienThiDS(Form3 form3)
        {
            if(soLuongSach >= 1)
            {
                sapXepTangDan();
            }
            for (int i = 0; i < soLuongSach; i++)
            {
                string labelText = "ISBN: " + dsSach[i].ISBN + " || Tên sách: " + dsSach[i].tenSach + " || Năm xuất bản: " + dsSach[i].namXB + " || Số trang: " + dsSach[i].soTrang + " || Tên tác giả: " + dsSach[i].tacGia + " || Mã sách: " + dsSach[i].maSach + " || Thể loại: " + dsSach[i].theLoai + " || Trạng thái sách: " + dsSach[i].trangThaiSach;
                form3.LabelValue += labelText + Environment.NewLine;
            }
            form3.UpdateLabelValue(form3.LabelValue);
        }
        private void sapXepTangDan()
        {
            for (int i = 0; i < soLuongSach; i++)
            {
                for (int j = soLuongSach - 1; j > i; j--)
                {
                    if (dsSach[j].tenSach[0].CompareTo(dsSach[j - 1].tenSach[0]) < 0)
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
