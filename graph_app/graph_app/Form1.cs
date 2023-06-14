using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace graph_app
{
    public partial class Form1 : Form
    {
        public class timing
        {
            private DateTime startTime;
            private DateTime stopTime;
            public void start()
            {
                startTime = DateTime.Now;
            }
            public void stop()
            {
                stopTime = DateTime.Now;
                TimeSpan elasedTime = stopTime - startTime;
                MessageBox.Show($"Thời gian thực hiện là {elasedTime}", "Time Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                    MessageBox.Show("Stack is full !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Stack is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Stack is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("queue is full !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("queue is empty !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public class Graph
        {
            private const int NUM_VERTICES = 6; //Số lượng đỉnh là 20
            public Vertex[] vertices; //tạo mảng chứa các đỉnh
            private int[,] adjMatrix; //Tạo mảng 2 chiều chứa các cạnh
            public int numVerts;

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
            
            private int GetAdjUnvisitedVertex(int v)
            {
                for (int j = 0; j <= numVerts - 1; j++)
                    if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
                        return j;
                return -1;
            }
            //Thuật toán tìm kiếm theo chiều sâu bắt đầu từ 0
            public String depthFirstSearch(int n)
            {
                String result = null;
                int_stack s = new int_stack(numVerts);
                vertices[0].wasVisited = true;
                s.push(0);
                int v;
                if(n < numVerts)
                {
                    while (s.length() > 0)
                    {
                        v = GetAdjUnvisitedVertex(s.peek());
                        if (v == -1) s.pop();
                        else
                        {
                            vertices[v].wasVisited = true;
                            if (v == n)
                            {
                                result = vertices[v].label;
                                break;
                            }
                            s.push(v);
                        }
                    }
                    for (int j = 0; j < numVerts; j++)
                    {
                        vertices[j].wasVisited = false;
                    }
                }
                return result;
            }
            //Thuật toán tìm kiếm theo chiều rộng (BFS)
            public String breadthFirstSearch(int n)
            {
                String result = null;
                queue q = new queue(numVerts);
                vertices[0].wasVisited = true;
                q.enqueue(0);
                int vert1, vert2;
                while (q.size > 0)
                {
                    vert1 = q.dequeue();
                    vert2 = GetAdjUnvisitedVertex(vert1);
                    while (vert2 != -1)
                    {
                        vertices[vert2].wasVisited = true;
                        if (vert2 == n)
                        {
                            result = vertices[vert2].label;
                            break;
                        }
                        q.enqueue(vert2);
                        vert2 = GetAdjUnvisitedVertex(vert1);
                    }
                }
                for (int j = 0; j < numVerts; j++)
                {
                    vertices[j].wasVisited = false;
                }
                return result;
            }
        }
        Graph tphcm = new Graph();
        public Form1()
        {
            InitializeComponent();
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
            txtKq.Text = "Graph TPHCM gồm có các đỉnh:\n";
            for (int i = 0; i < tphcm.numVerts; i++)
            {
                txtKq.Text += tphcm.vertices[i].label + " ";
            }
            dfsBtn.Enabled = true;
            bfsBtn.Enabled = true;
            findBtn.Enabled = false;
            findTxt.Enabled = false;
            backBtn.Enabled = false;
            timer1.Enabled = false;
        }

        private void dfsBtn_Click(object sender, EventArgs e)
        {
            bfsBtn.Enabled = false;
            findBtn.Enabled = true;
            findTxt.Enabled = true;
            backBtn.Enabled = true;
        }
        private void bfsBtn_Click(object sender, EventArgs e)
        {
            dfsBtn.Enabled = false;
            findBtn.Enabled = true;
            findTxt.Enabled = true;
            backBtn.Enabled = true;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if(dfsBtn.Enabled == true)
            {
                timing time = new timing();
                time.start();
                int n = Convert.ToInt32(findTxt.Text);
                String result = tphcm.depthFirstSearch(n);
                time.stop();
                if (n >= tphcm.numVerts)
                {
                    MessageBox.Show("Try another n with n from 0 to 4 !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Đỉnh {n} trong graph TPHCM là {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                findTxt.Focus();
                findTxt.Clear();
            }
            if (bfsBtn.Enabled == true)
            {
                timing time = new timing();
                time.start();
                int n = Convert.ToInt32(findTxt.Text);
                String result = tphcm.breadthFirstSearch(n);
                time.stop();
                if (n >= tphcm.numVerts)
                {
                    MessageBox.Show("Try another n with n from 0 to 4 !!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show($"Đỉnh {n} trong graph TPHCM là {result}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                findTxt.Focus();
                findTxt.Clear();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            dfsBtn.Enabled = true;
            bfsBtn.Enabled = true;
            findBtn.Enabled = false;
            findTxt.Enabled = false;
            for (int j = 0; j < tphcm.numVerts; j++)
            {
                tphcm.vertices[j].wasVisited = false;
            }
        }
    }
}
