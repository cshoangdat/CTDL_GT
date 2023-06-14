using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyThuVien
{
    class danhSachMuonTra
    {
        public Node_linkedList head;
        public Node_linkedList tail;
        public int size;
        public danhSachMuonTra()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool isempty()
        {
            return size == 0;
        }
        public void themsach(sach sach) {
            Node_linkedList newest = new Node_linkedList(sach, null);
            if (isempty()) head = newest;
            else tail.next = newest;
            tail = newest;
            size += 1;
        }
    }
}
