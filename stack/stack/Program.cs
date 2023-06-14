using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        /*
         Bộ nhớ xếp chồng 
        push (obj) thêm phần tử vô
        pop () bỏ phần tử ra(phần tử cuối) 
        top() trả về phần tử cuối cùng
        len(): trả về số lượng phần tử
        isEmpty(): kiểm tra có rỗng không
        Biển mảng thành stack
         */
        public class stackArray
        {
            int[] data;
            int top;
            public stackArray(int n)
            {
                data = new int[n];
                top = 0;
            }
            public int length()
            {
                return top;
            }
            public bool isempty()
            {
                return top == 0;
            }
            public bool isfull()
            {
                return top == data.Length;
            }
            public void push(int e)
            {
                if (isfull())
                {
                    Console.WriteLine("Mang full");
                }
                else
                {
                    data[top] = e;
                    top = top + 1;
                }
            }
            public int pop()
            {
                if (isempty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                int e = data[top - 1];
                top = top - 1;
                return e;
            }
            public int peek()
            {
                if (isempty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                return data[top - 1];
            }
            public void display()
            {
                for(int i = 0;i < top; i++)
                {
                    Console.Write(data[i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            stackArray s = new stackArray(10);
            s.push(4);
            s.push(3);
            s.push(2);
            s.push(100);
            s.push(50);
            s.display();
            s.pop();
            s.display();
            int num = s.peek();
            Console.WriteLine(num);
        }
    }
}
