using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_form
{
    public class Node
    {
        public object element;
        public Node next;
        public Node(object e)
        {
            element = e;
            next = null;
        }
    }
    class queueLinkedList
    {
        Node front;
        Node rear;
        int size;
        public queueLinkedList()
        {
            front = null;
            rear = null;
            size = 0;
        }
        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }
        public void enqueue(object e)
        {
            Node newest = new Node(e);
            if (isEmpty())
                front = newest;
            else
                rear.next = newest;
            rear = newest;
            size = size + 1;
        }
        public object dequeue()
        {
            if (isEmpty())
            {
                return -1;
            }
            object e = front.element;
            front = front.next;
            size = size - 1;
            return e;
        }
    }
}
