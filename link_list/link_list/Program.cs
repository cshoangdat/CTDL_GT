using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link_list
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Danh sách liên kết là 1 loại kiểu dữ liệu
             Node: [data,link]:
             trong đó data là kiểu dữ liệu(int,float,string,...)
             link: Chứa địa chỉ của ô nhớ phần tử kế tiếp
             mỗi phần tử trong link list là 1 node các node có địa chỉ khác nhau( không liên tiếp)
             giải quyết vấn đề tuần tự của mảng
             để liên kết 2 node: trỏ tới địa chỉ của ô nhớ phía sau vd: n1.next = n2
             */
            linkedList l = new linkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.addFirst(15);
            l.addAny(23, 2);
            Console.Write("List ban dau: ");
            l.display();
            int index = l.search(4);
            Console.WriteLine($"4 tai vi tri thu: {index}");
            int element = l.removeFirst();
            Console.WriteLine($"Da xoa phan tu: {element}");
            int lastElement = l.removeLast();
            Console.WriteLine($"Da xoa phan tu cuoi: {lastElement}");
            int anyElement = l.removeAny(2);
            Console.WriteLine($"Da xoa phan tu thu 2: {anyElement}");
            l.display();
            Console.WriteLine(l.length());
        }
        //Định nghĩa 1 node
        public class Node
        {
            public int element;
            public Node next; //Node là kiểu dữ liệu con trỏ
            public Node(int e,Node n)
            {
                element = e;
                next = n;
            }
        }
        //Tạo liên kết và tạo ds liên kết
        /*
         function addlast(e)
            newest = Node(e,Null)
            if isempty() then  head = newest

            else{
                tail.next = newest    
            }
            tail = newest
            size = size + 1

        function display(){
            p = head
            while p{
                print(p.element)
                p = p.next
            }
        }

        - Chèn phần tử đầu tiên của mảng:
            function addFirst(e){
                newest = Node(e,null)
                if(isempty() then)
                {
                    head = newest
                    tail = newest
                }
                else
                {
                    newest.next = head
                    head = newest
                }
                size = size +1
            }
         */
        class linkedList
        {
            private Node head;
            private Node tail;
            private int size;
            public linkedList()
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
            public void addLast(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    head = newest;
                }
                else
                {
                    tail.next = newest;
                }
                tail = newest;
                size = size + 1;
            }
            public void addFirst(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head = newest;
                }
                size = size + 1;
            }
            public void display()
            {
                Node p = head;
                while (p != null)
                {
                    Console.Write(p.element + " ");
                    p = p.next;
                }
                Console.WriteLine();
            }
            public void addAny(int e, int position)
            {
                if(position <= 0 || position >= size)
                {
                    Console.WriteLine("Invalid Position");
                }
                Node newest = new Node(e, null);
                Node p = head;
                int i = 1;
                while (i<position- 1)
                {
                    p = p.next;
                    i++;
                }
                newest.next = p.next;
                p.next = newest;
                size = size + 1;
            }
            public int removeFirst()
            {
                if (isempty())
                {
                    Console.WriteLine("List is empty");
                    return -1;
                }
                else
                {
                    int e = head.element;
                    head = head.next;
                    size = size - 1;
                    if (isempty())
                    {
                        tail = null;
                    }
                    return e;
                }
            }
            public int removeLast()
            {
                if (isempty())
                {
                    Console.WriteLine("List is empty");
                    return -1;
                }
                else
                {
                    Node p = head;
                    int i = 1;
                    while(i< length() - 1)
                    {
                        p = p.next;
                        i += 1;
                    }
                    tail = p;
                    p = p.next;
                    int e = p.element;
                    tail.next = null;
                    size = size - 1;
                    return e;
                }
            }
            public int removeAny(int position)
            {
                if (position <= 0 || position >= size)
                {
                    Console.WriteLine("Invalid Position");
                    return -1;
                }
                Node p = head;
                int i = 1;
                while (i < position - 1)
                {
                    p = p.next;
                    i += 1;
                }
                int e = p.next.element;
                p.next = p.next.next;
                size = size - 1;
                return e;
            }
            public int search(int key)
            {
                Node p = head;
                int index = 0;
                while (p != null)
                {
                    if(p.element == key)
                    {
                        return index;
                    }
                    p = p.next;
                    index = index + 1;
                }
                return -1;
            }
        }
    }
}
