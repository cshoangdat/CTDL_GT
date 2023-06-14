using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_onclass
{
    class Program
    {
        class graph
        {
            int vertices;
            int[,] adjMat;
            public graph(int n)
            {
                vertices = n;
                adjMat = new int[n, n];
            }
            public void insertEdge(int u, int v, int x)
            {
                adjMat[u, v] = x;
            }
            public void removeEdge(int u, int v)
            {
                adjMat[u, v] = 0;
            }
            public bool existEdge(int u, int v)
            {
                return adjMat[u, v] != 0;
            }
            public int vertexCount()
            {
                return vertices;
            }
            public int edgeCount()
            {
                int count = 0;
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjMat[i, j] != 0)
                            count += 1;
                    }
                }
                return count;
            }
            public void edge()
            {
                Console.WriteLine("Edges: ");
                for(int i = 0; i<vertices; i++)
                {
                    for(int j = 0; j<vertices; j++)
                    {
                        if (adjMat[i, j] != 0)
                            Console.WriteLine(i + "--" + j);
                    }
                }
            }
            public int outdegree(int v)
            {
                int count = 0;
                Console.WriteLine("Edge: ");

                for (int j = 0; j < vertices; j++)
                    if (adjMat[v, j] != 0)
                        count++;
                return count;

            }
            public int indegree(int v)
            {
                int count = 0;
                for (int i = 0; i < vertices; i++)
                    if (adjMat[i, v] != 0)
                        count++;
                return count;

            }

            public void display()
            {
                for( int i = 0; i< vertices; i++)
                {
                    for(int j = 0; j< vertices; j++)
                    {
                        Console.Write(adjMat[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            graph g = new graph(4);
            Console.WriteLine(" Graph...");
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edge Count: " + g.edgeCount());
            g.insertEdge(0, 1, 1);
            g.insertEdge(0, 2, 1);
            g.insertEdge(1, 0, 1);
            g.insertEdge(1, 2, 1);
            g.insertEdge(2, 0, 1);
            g.insertEdge(2, 1, 1);
            g.insertEdge(3, 2, 1);
            g.insertEdge(2, 3, 1);
            g.display();
            Console.WriteLine("Vertices: " + g.vertexCount());
            Console.WriteLine("Edge Count: " + g.edgeCount());



        }
    }
}
