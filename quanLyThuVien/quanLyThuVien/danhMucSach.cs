using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyThuVien
{
    class Node_linkedList
    {
        public sach element;
        public Node_linkedList next;
        public Node_linkedList(sach e, Node_linkedList n)
        {
            element = e;
            next = n;
        }
    }
    class danhMucSach
    {
        public Node_linkedList head;
        public Node_linkedList tail;
        public int size;
        public danhMucSach()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool isempty()
        {
            return size == 0;
        }
        public int length()
        {
            return size;
        }
        public void themSach(sach e)
        {
            Node_linkedList newest = new Node_linkedList(e,null);
            if (isempty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size += 1;
        }
        public void xoaSach(int maSach)
        {
            if(isempty()) return;
            if (head.element.maSach == maSach) head = head.next;
            else
            {
                Node_linkedList p = head;
                while(p.next != null && p.next.element.maSach != maSach)
                {
                    p = p.next;
                }
                if(p.next != null)
                {
                    p.next = p.next.next;
                }
            }
            size -= 1;
        }
        public void hienThiDanhMuc()
        {
            if (isempty())
            {
                return;
            }
            Node_linkedList p = head;
            while(p != null)
            {
                Console.WriteLine("Ma sach: " + p.element.maSach + ", Trang thai: " + p.element.trangThaiSach + ", Vi tri: " + p.element.viTri);
                p = p.next;
            }
        }
    }
}
