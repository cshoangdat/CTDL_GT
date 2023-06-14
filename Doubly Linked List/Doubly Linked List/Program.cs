using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    /*
     Doubly Linked List 1 Node chứa 3 ô 
     */
    class Program
    {
        public class Node
        {
            public int element;
            public Node next;
            public Node prev;
            public Node(int e, Node n, Node p) {
                element = e;
                next = n;
                prev = p;
            }
        }
        public class doublyLinkedList
        {
            public Node head = null;
            public int size = 0;
            public Node tail = null;

            public bool isempty()
            {
                return size == 0;
            }

            public void addLast(int e)
            {
                Node newest = new Node(e, null, null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    tail.next = newest;
                    newest.prev = tail;
                    tail = newest;
                }
                size = size + 1;
            }
            public void addFirst(int e)
            {
                Node newest = new Node(e, null, null);
                if (isempty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.next = head;
                    head.prev = newest;
                    head = newest;
                }
                size = size + 1;
            }
            public void addAny(int e, int pos)
            {
                Node newest = new Node(e, null, null);
                Node p = head;
                int i = 1;
                while(i<pos - 1)
                {
                    p = p.next;
                    i++;
                }
                newest.next = p.next;
                p.next.prev = newest;
                p.next = newest;
                newest.prev = p;
                size = size + 1;
            }
            public int removeFirst()
            {
                int result = 0;
                if (isempty())
                {
                    Console.WriteLine("khong co phan tu nao");
                    result = -1;
                }
                result = head.element;
                head = head.next;
                head.prev = null;
                size = size - 1;
                return result;
            }
            public int removeLast()
            {
                int result = 0;
                result = tail.element;
                Node p = head;
                int i = 1;
                while(i<size - 1)
                {
                    p = p.next;
                    i++;
                }
                tail = p;
                p.next = null;
                size = size - 1;
                return result;
            }
            public int removeAny(int pos)
            {
                int result = 0;
                Node p = head;
                int i = 1;
                while(i < pos - 1)
                {
                    p = p.next;
                    i++;
                }
                result = p.next.element;
                p.next = p.next.next;
                p.next.prev = p;
                size = size - 1;
                return result;
            }
            public int search(int key)
            {
                int result = 0;
                Node p = head;
                int i = 1;
                while (i < size)
                {
                    if (p.element == key) result = i;
                    p = p.next;
                    i++;
                }
                return result;
            }
            public void display()
            {
                Node p = head;
                while(p != null)
                {
                    Console.Write(p.element + " ");
                    p = p.next;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            doublyLinkedList l = new doublyLinkedList();
            l.addLast(12);
            l.addLast(23);
            l.addFirst(34);
            l.addFirst(78);
            l.addAny(5, 2);
            l.display();
            int num = l.removeAny(2);
            Console.WriteLine($"Da xoa phan tu 2");
            l.display();
            num = l.removeFirst();
            Console.WriteLine($"Da xoa phan tu dau la {num}");
            l.display();
            num = l.removeLast();
            Console.WriteLine($"Da xoa phan tu cuoi la {num}");
            l.display();
            num = l.search(34);
            Console.WriteLine($"phan tu 34 nam o vi tri {num}");
            l.display();
        }
    }
}
