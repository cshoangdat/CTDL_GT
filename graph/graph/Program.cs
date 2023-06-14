using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThi1
{
    //khởi tạo class đỉnh
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
    public class gStack
    {
        public int top;
        public String[] data;
        public gStack(int n)
        {
            data = new string[n];
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
        public void push(String e)
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
        public String pop()
        {
            String result = null;
            if (isempty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                String e =  data[top - 1];
                top = top - 1;
                result = e;
            }
            return result;
        }
        public void display()
        {
            for(int i = 0; i < top; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
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
    public class queue
    {
        int rear;
        int front;
        int[] data;
        public int size;
        public queue(int n)
        {
            rear = 0;
            front = 0;
            data = new int[n];
            size = 0;
        }
        public bool isempty()
        {
            return size == 0;
        }
        public bool isfull()
        {
            return size == data.Length;
        }
        public void enqueue(int e)
        {
            if (isfull())
            {
                Console.WriteLine("queue is full");
            }
            else
            {
                data[rear] = e;
                rear = rear + 1;
                size = size + 1;
            }
        }
        public int dequeue()
        {
            int result = 0;
            if (isempty())
            {
                Console.WriteLine("queue is empty");
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
    }
    //Khởi tạo class graph
    public class Graph
    {
        private const int NUM_VERTICES = 20; //Số lượng đỉnh là 20
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
        //Tìm đỉnh không có liên kết với đỉnh kế tiếp: Khi đỉnh đó có tất cả cột = 0, nếu không có đỉnh nào k có liên kết sẽ trả về -1
        public int NoSuccessors()
        {
            bool isEdge;
            int row;
            for (row = 0; row <= numVerts - 1; row++)
            {
                isEdge = false;
                for (int col = 0; col <= numVerts - 1; col++)
                    if (adjMatrix[row, col] > 0)
                    {
                        isEdge = true;
                        break;
                    }
            }
            if (isEdge = true)
                return row;
            else
                return -1;
        }
        //Loại bỏ đỉnh khỏi graph:
        //B1: xóa đỉnh đó ra khỏi ma trận đỉnh
        //B2: Xóa hàng, cột đó khỏi ma trận kề, di chuyển hàng và cột để lắp
        private void MoveRow(int row, int length)
        {
            for (int col = 0; col <= length - 1; col++)
                adjMatrix[row, col] = adjMatrix[row + 1, col];
        }
        private void MoveCol(int col, int length)
        {
            for (int row = 0; row <= length - 1; row++)
                adjMatrix[row, col] = adjMatrix[row, col + 1];
        }
        public void DelVertex(int vert)
        {
            if (vert < numVerts)
            {
                for (int i = vert; i < numVerts - 1; i++)
                {
                    vertices[i] = vertices[i + 1];
                    for (int j = 0; j < numVerts; j++)
                    {
                        adjMatrix[i, j] = adjMatrix[i + 1, j];
                        adjMatrix[j, i] = adjMatrix[j, i + 1];
                    }
                }
                numVerts--;
            }
        }
        //Thuật toán sắp xếp topo dựa trên việc xóa các đỉnh k liền kề r đưa vào stack
        public void topSort()
        {
            gStack s = new gStack(numVerts);
            while (numVerts > 0)
            {
                int currVertex = NoSuccessors();
                if (currVertex == -1)
                {
                    Console.WriteLine("Error: graph has cycles.");
                    return;
                }
                s.push(vertices[currVertex-1].label);
                DelVertex(currVertex-1);
            }

            Console.Write("Topological sort: ");
            while (s.length() > 0)
                Console.Write(s.pop() + " ");
            Console.WriteLine();
        }
        //DFS: tìm kiếm theo chiều sâu
        //Kiểm tra node đó đã đc visited chưa
        private int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j <= numVerts - 1; j++)
                if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
                    return j;
            return -1;
        }
        //Thuật toán tìm kiếm theo chiều sâu bắt đầu từ 0
        private void depthFirstSearch()
        {
            int_stack s = new int_stack(numVerts);
            vertices[0].wasVisited = true;
            ShowVertex(0);
            s.push(0);
            int v;
            while(s.length() > 0)
            {
                v = GetAdjUnvisitedVertex(s.peek());
                if (v == -1) s.pop();
                else
                {
                    vertices[v].wasVisited = true;
                    ShowVertex(v);
                    s.push(v);
                }
            }
            for(int j = 0; j <numVerts; j++)
            {
                vertices[j].wasVisited = false;
            }
        }
        //Thuật toán tìm kiếm theo chiều rộng (BFS)
        private void breadthFirstSearch()
        {
            queue q = new queue(numVerts);
            vertices[0].wasVisited = true;
            ShowVertex(0);
            q.enqueue(0);
            int vert1, vert2;
            while(q.size > 0)
            {
                vert1 = q.dequeue();
                vert2 = GetAdjUnvisitedVertex(vert1);
                while(vert2 != -1)
                {
                    vertices[vert2].wasVisited = true;
                    ShowVertex(vert2);
                    q.enqueue(vert2);
                    vert2 = GetAdjUnvisitedVertex(vert1);
                }
            }
            for (int j = 0; j < numVerts; j++)
            {
                vertices[j].wasVisited = false;
            }
        }
        //Cây bao trùm tối thiểu
        public void mst()
        {
            vertices[0].wasVisited = true;
            int_stack s = new int_stack(numVerts);
            s.push(0);
            int currVertex, ver;
            while(s.length() > 0)
            {
                currVertex = s.peek();
                ver = GetAdjUnvisitedVertex(currVertex);
                if (ver == -1) s.pop();
                else
                {
                    vertices[ver].wasVisited = true;
                    s.push(ver);
                    ShowVertex(currVertex);
                    ShowVertex(ver);
                    Console.Write(" ");
                }
            }
            for (int j = 0; j < numVerts; j++)
            {
                vertices[j].wasVisited = false;
            }
        }
        
        static void Main(string[] args)
        {
            //Graph aGraph = new Graph();
            //aGraph.AddVertex("A");
            //aGraph.AddVertex("B");
            //aGraph.AddVertex("C");
            //aGraph.AddVertex("D");
            //aGraph.AddVertex("E");
            //aGraph.AddVertex("F");
            //aGraph.AddVertex("G");
            //aGraph.AddVertex("H");
            //aGraph.AddVertex("I");
            //aGraph.AddVertex("J");
            //aGraph.AddVertex("K");
            //aGraph.AddVertex("L");
            //aGraph.AddVertex("M");
            //aGraph.AddEdge_directed(0, 1);
            //aGraph.AddEdge_directed(1, 2);
            //aGraph.AddEdge_directed(2, 3);
            //aGraph.AddEdge_directed(0, 4);
            //aGraph.AddEdge_directed(4, 5);
            //aGraph.AddEdge_directed(5, 6);
            //aGraph.AddEdge_directed(0, 7);
            //aGraph.AddEdge_directed(7, 8);
            //aGraph.AddEdge_directed(8, 9);
            //aGraph.AddEdge_directed(0, 10);
            //aGraph.AddEdge_directed(10, 11);
            //aGraph.AddEdge_directed(11, 12);
            ////aGraph.depthFirstSearch();
            //aGraph.breadthFirstSearch();
            //Console.WriteLine();

            Graph aGraph = new Graph();
            aGraph.AddVertex("A");
            aGraph.AddVertex("B");
            aGraph.AddVertex("C");
            aGraph.AddVertex("D");
            aGraph.AddVertex("E");
            aGraph.AddVertex("F");
            aGraph.AddVertex("G");
            aGraph.AddEdge_directed(0, 1);
            aGraph.AddEdge_directed(0, 2);
            aGraph.AddEdge_directed(0, 3);
            aGraph.AddEdge_directed(1, 2);
            aGraph.AddEdge_directed(1, 3);
            aGraph.AddEdge_directed(1, 4);
            aGraph.AddEdge_directed(2, 3);
            aGraph.AddEdge_directed(2, 5);
            aGraph.AddEdge_directed(3, 5);
            aGraph.AddEdge_directed(3, 4);
            aGraph.AddEdge_directed(3, 6);
            aGraph.AddEdge_directed(4, 5);
            aGraph.AddEdge_directed(4, 6);
            aGraph.AddEdge_directed(5, 6);
            Console.WriteLine();
            aGraph.mst();
        }
    }
}
