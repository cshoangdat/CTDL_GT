using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    /*
    FIFO
    euqueue(obj): insert element
    dequeue(): remove & return element
    first(): return first element
    len(): Chieu dai queue
    isempty()
     */
    //Queue Array
    class Program
    {
        class queueArray
        {
            int[] data;
            int front;
            int rear;
            int size;
            public queueArray(int n)
            {
                data = new int[n];
                front = 0;
                size = 0;
                rear = 0;
            }
            public bool isempty()
            {
                return size == 0;
            }
            public int length()
            {
                return size;
            }
            public bool isfull()
            {
                return size == data.Length; 
            }
            public void enqueue(int e)
            {
                if (isfull())
                {
                    Console.WriteLine("Array is full");
                }
                data[rear] = e;
                rear = rear + 1;
                size = size + 1;
            }
            public int dequeue()
            {
                int result = 0;
                if (isempty())
                {
                    Console.WriteLine("Array is empty");
                    result = -1;
                }
                else
                {
                result = data[front];
                front = front + 1;
                size = size - 1;
                }
                return result;
            }
            public int firstValue()
            {
                int result = 0;
                if (isempty())
                {
                    Console.WriteLine("Array is empty");
                    result = -1;
                }
                else result = data[front];
                return result;
            }
            public void display()
            {
                for(int i = front; i < rear; i++)
                {
                    Console.Write(data[i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            queueArray arr = new queueArray(5);
            arr.enqueue(5);
            arr.enqueue(4);
            arr.enqueue(9);
            arr.enqueue(2);
            arr.display();
            int num = arr.dequeue();
            Console.WriteLine($"Da bo phan tu dau: {num}");
            arr.display();
            num = arr.firstValue();
            Console.WriteLine($"Phan tu dau cua mang la: {num}");
            Console.WriteLine(arr.length());
        }
    }
}
