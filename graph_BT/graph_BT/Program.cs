using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_BT
{
    class Program
    {
        public class Vertex
        {
            public bool wasVisited;
            public string label;
            public Vertex(string label)
            {
                this.label = label;
                wasVisited = false;
            }
        }
        public class Graph
        {
            private const int NUM_VERTICES = 6; //Số lượng đỉnh là 6
            private Vertex[] vertices; //tạo mảng chứa các đỉnh
            private int[,] adjMatrix; //Tạo mảng 2 chiều chứa các cạnh
            int numVerts;

            public Graph()
            {
                vertices = new Vertex[NUM_VERTICES]; //Mảng vertices có tối đa 20 phần tử vertex
                adjMatrix = new int[NUM_VERTICES, NUM_VERTICES]; //tạo mảng 2 chiều có độ lớn là 20x20
                numVerts = 0;
                //Duyệt mảng 2 chiều khởi tạo các cạnh là 0
                for (int j = 0; j <= NUM_VERTICES - 1; j++)
                    for (int k = 0; k <= NUM_VERTICES - 1; k++)
                        adjMatrix[j, k] = 0;
            }
            //Thêm đỉnh
            public void AddVertex(string label)
            {
                vertices[numVerts] = new Vertex(label);
                numVerts++;
            }
            //Thêm cạnh
            public void AddEdge_directed(int start, int eend)
            {
                adjMatrix[start, eend] = 1;
            }
            public void AddEdge_undirected(int start, int eend)
            {
                adjMatrix[start, eend] = 1;
                adjMatrix[eend, start] = 1;
            }
            //Hiện thị các đỉnh
            public void ShowVertex(int v)
            {
                Console.Write(vertices[v].label + " ");
            }
            //Kiểm tra node đó đã đc visited chưa
            private int GetAdjUnvisitedVertex(int v)
            {
                for (int j = 0; j <= numVerts - 1; j++)
                    if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
                        return j;
                return -1;
            }
            public class int_stack
            {
                public int top;
                public int[] data;
                public int_stack(int n)
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
                        Console.WriteLine("Stack is full");
                    }
                    else
                    {
                        data[top] = e;
                        top = top + 1;
                    }
                }
                public int pop()
                {
                    int result = 0;
                    if (isempty())
                    {
                        Console.WriteLine("Stack is empty");
                    }
                    else
                    {
                        int e = data[top - 1];
                        top = top - 1;
                        result = e;
                    }
                    return result;
                }
                public int peek()
                {
                    int result = 0;
                    if (isempty())
                    {
                        Console.WriteLine("Stack is empty");
                        result = -1;
                    }
                    else result = data[top - 1];
                    return result;
                }
                public void display()
                {
                    for (int i = 0; i < top; i++)
                    {
                        Console.Write(data[i] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void mst()
            {
                vertices[0].wasVisited = true;
                int_stack s = new int_stack(numVerts);
                s.push(0);
                int currVertex, ver;
                while (s.length() > 0)
                {
                    currVertex = s.peek();
                    ver = GetAdjUnvisitedVertex(currVertex);
                    if (ver == -1) s.pop();
                    else
                    {
                        vertices[ver].wasVisited = true;
                        s.push(ver);
                        Console.Write($"({vertices[currVertex].label} {vertices[ver].label}) ");
                    }
                }
                for (int j = 0; j < numVerts; j++)
                {
                    vertices[j].wasVisited = false;
                }
            }
            static void Main(string[] args)
            {
                Graph tphcm = new Graph();
                tphcm.AddVertex("Thu Duc");
                tphcm.AddVertex("Quan 9");
                tphcm.AddVertex("Quan 2");
                tphcm.AddVertex("Quan 4");
                tphcm.AddVertex("Quan 7");
                tphcm.AddEdge_directed(0, 1);
                tphcm.AddEdge_directed(0, 2);
                tphcm.AddEdge_directed(1, 2);
                tphcm.AddEdge_directed(2, 3);
                tphcm.AddEdge_directed(2, 4);
                tphcm.AddEdge_directed(3, 4);
                tphcm.mst();
            }
        }
    }
}
