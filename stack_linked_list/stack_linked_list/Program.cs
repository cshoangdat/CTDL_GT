using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_linked_list
{
    class Program
    {
        public class Node
        {
            public int element;
            public Node next;
            public Node(int e, Node n) {
                element = e;
                next = n;
            }
        }
        public class stacksLinkedList
        {
            public int size;
            public Node top;
            public stacksLinkedList()
            {
                size = 0;
                top = null;
            }
            public bool isempty()
            {
                return size == 0;
            }
            public void push(int e)
            {
                Node newest = new Node(e, null);
                if (isempty())
                {
                    top = newest;
                }
                else
                {
                    newest.next = top;
                    top = newest;
                }
                size = size + 1;
            }
            public int pop()
            {
                if (isempty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                else
                {
                    int e = top.element;
                    top = top.next;
                    size = size - 1;
                    return e;
                }
            }
            public int peek()
            {
                if (isempty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                else
                {
                    int e = top.element;
                    return e;
                }
            }
            public void display()
            {
                Node p = top;
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
            stacksLinkedList l = new stacksLinkedList();
            l.push(10);
            l.push(5);
            l.push(9);
            l.push(3);
            l.display();
            int num = l.pop();
            Console.WriteLine($"Bo phan tu dau cua mang la: {num}");
            l.display();
            num = l.peek();
            Console.WriteLine($"Phan tu dau cua list: {num} ");
        }
    }
}
