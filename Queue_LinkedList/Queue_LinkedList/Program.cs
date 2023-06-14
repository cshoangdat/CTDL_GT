using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_LinkedList
{
    class Program
    {
        class Node
        {
            public int element;
            public Node next;
            public Node(int e, Node n)
            {
                element = e;
                next = n;
            }
        }
        class queueLinkedList
        {
            public Node front = null;
            public Node rear = null;
            public int size = 0;
            public bool isempty()
            {
                return size == 0;
            }

            public void enQueue(int e) //add Last
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    front = newest;
                    rear = newest;
                }
                else
                {
                    rear.next = newest;
                    rear = newest;
                }
                size = size + 1;
            }
            public int deQueue() //remove First
            {
                int result = 0;
                if (isempty())
                {
                    result = -1;
                    Console.WriteLine("Linked list is empty");
                }
                else
                {
                    result = front.element;
                    front = front.next;
                }
                size = size - 1;
                return result;
            }
            public int firstValue()
            {
                int result = 0;
                if (isempty())
                {
                    result = -1;
                    Console.WriteLine("Linked list is empty");
                }
                else
                {
                    result = front.element;
                }
                return result;
            }
            public void display()
            {
                Node p = front;
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
            queueLinkedList l = new queueLinkedList();
            l.enQueue(10);
            l.enQueue(5);
            l.enQueue(6);
            l.enQueue(9);
            l.display();
            l.deQueue();
            l.display();
            int num = l.firstValue();
            Console.WriteLine($"Gia tri dau lien cua linked list la: {num}");
        }
    }
}
