using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            circularLinkedList l = new circularLinkedList();
            //Thêm các phần tử 8 7 2 4 vào cuối
            l.addLast(8);
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            //Thêm các phần tử 14 45 90 vào đầu
            l.addFirst(14);
            l.addFirst(45);
            l.addFirst(90);
            //Thêm phần tử 34 tại vị trí 4(List bắt đầu từ 0)
            l.addAny(34,4);
            //KQ: 90 45 14 8 34 7 2 4
            Console.Write("List: ");
            l.display();
            //Xóa phần từ đầu
            int num = l.removeFirst();
            //KQ: 45 14 8 34 7 2 4
            Console.WriteLine($"Da xoa phan tu dau tien cua mang la {num} ");
            l.display();
            //Xóa phần từ cuối
            num = l.removeLast();
            //KQ: 45 14 8 34 7 2
            Console.WriteLine("Da xoa phan tu cuoi cua mang");
            l.display();
            //Xóa phần tử tại vị trí 3 (list bắt đầu từ 0)
            num = l.removeAny(3);
            //KQ: 45 14 8 7 4
            Console.WriteLine($"Da xoa phan tu thu 3 cua mang");
            l.display();
            //Tìm phần tử có giá trị 7 trong List
            int search = l.search(7);
            if(search == -1)
            {
                Console.WriteLine("Khong ton tai trong mang");
            }
            else Console.WriteLine($"Phan tu 7 tai vi tri thu {search}");
        }
        public class Node
        {
            public int element;
            public Node next;
            public Node(int e, Node n)
            {
                element = e;
                next = n;
            }
        }
        public class circularLinkedList
        {
            private Node head;
            private Node tail;
            private int size;
            public circularLinkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public int length()
            {
                return size;
            }
            public bool isempty()
            {
                return size == 0;
            }
            //Thêm vào vị trí cuối của list
            public void addLast(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    newest.next = newest;
                    head = newest;
                }
                else
                {
                    tail.next = newest;
                    newest.next = head; //tail.next = head
                }
                tail = newest;
                size = size + 1;
            }
            //Thêm vào vị trí đầu của list
            public void addFirst(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    newest.next = newest;
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head = newest;
                    tail.next = head;
                }
                size = size + 1;
            }
            //Thêm vào vị trí bất kỳ của List
            public void addAny(int e, int pos)
            {
                Node newest = new Node(e, null);
                Node p = head;
                int i = 0;
                while (i < pos - 1)
                {
                    p = p.next;
                    i++;
                }
                newest.next = p.next;
                p.next = newest;
                tail.next = head;
                size = size + 1;
            }
            //Xóa thành phần đầu tiên của List
            public int removeFirst()
            {
                int result = 0;
                if (isempty())
                {
                    Console.WriteLine("List is empty");
                    result = -1;
                }
                else
                {
                    result = head.element;
                    head = head.next;
                    tail.next = head;
                    size = size - 1;
                }
                return result;
            }
            //Xóa thành phần cuối cùng của List
            public int removeLast()
            {
                int result = 0;
                if (isempty())
                {
                    Console.WriteLine("List is empty");
                    return -1;
                }
                else
                {
                    Node p = head;
                    int i = 1;
                    while (i < size - 1)
                    {
                        p = p.next;
                        i++;
                    }
                    tail = p;
                    p = p.next;
                    result = tail.element;
                    tail.next = head;
                    size = size - 1;
                }
                return result;
            }
            //Xóa thành phần tại vị trí bất kỳ của List
            public int removeAny(int pos)
            {
                int result = 0;
                if (pos <= 0 || pos >= size)
                {
                    Console.WriteLine("position is False");
                    return -1;
                }
                else
                {
                    Node p = head;
                    int i = 0;
                    while(i < pos - 1)
                    {
                        p = p.next;
                        i++;
                    }
                    result = p.next.element;
                    p.next = p.next.next;
                    tail.next = head;
                    size = size - 1;
                }
                return result;
            }
            //Tìm vị trí và kiểm tra xem thành phần có tồn tại trong list không
            public int search(int key)
            {
                int result = -1;
                Node p = head;
                int i = 0;
                while (i < size)
                {
                    if(p.element == key)
                    {
                        result = i;
                    }
                    p = p.next;
                    i++;
                }
                return result;
            }
            //Hiện thị các thành phần có trong list
            public void display()
            {
                Node p = head;
                int i = 0;
                while (i < size)
                {
                    Console.Write(p.element + " ");
                    p = p.next;
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
