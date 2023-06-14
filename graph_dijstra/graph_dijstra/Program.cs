﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_dijstra
{
    class Program
    {
        public class DistOriginal
        {
            public int distance;
            public int parentVert;
            public DistOriginal(int pv, int d)
            {
                distance = d;
                parentVert = pv;
            }
        }
        public class Vertex
        {
            public string label;
            public bool isInTree;
            public Vertex(string lab)
            {
                label = lab;
                isInTree = false;
            }
        }
        public class Graph
        {
            private const int max_verts = 20;
            int infinity = 1000000;
            Vertex[] vertexList;
            int[,] adjMat;
            int nVerts;
            int nTree;
            DistOriginal[] sPath;
            int currentVert;
            int startToCurrent;
            public Graph()
            {
                vertexList = new Vertex[max_verts];
                adjMat = new int[max_verts, max_verts];
                nVerts = 0;
                nTree = 0;
                for (int j = 0; j <= max_verts - 1; j++)
                    for (int k = 0; k <= max_verts - 1; k++)
                        adjMat[j, k] = infinity;
                sPath = new DistOriginal[max_verts];
            }
            public void AddVertex(string lab)
            {
                vertexList[nVerts] = new Vertex(lab);
                nVerts++;
            }
            public void AddEdge(int start, int theEnd, int weight)
            {
                adjMat[start, theEnd] = weight;
            }
            public void Path()
            {
                int startTree = 0;
                vertexList[startTree].isInTree = true;
                nTree = 1;
                //Gan trong so cho cac canh
                for (int j = 0; j <= nVerts; j++)
                {
                    int tempDist = adjMat[startTree, j];
                    sPath[j] = new DistOriginal(startTree, tempDist);
                }

                while (nTree < nVerts)
                {
                    int indexMin = GetMin();
                    int minDist = sPath[indexMin].distance;
                    currentVert = indexMin;
                    startToCurrent = sPath[indexMin].distance;
                    vertexList[currentVert].isInTree = true;
                    nTree++;
                    AdjustShortPath();
                }
                DisplayPaths();
                nTree = 0;
                for (int j = 0; j <= nVerts - 1; j++)
                    vertexList[j].isInTree = false;
            }
            //Tim khoang cach nho nhat
            public int GetMin()
            {
                int minDist = infinity;
                int indexMin = 0;
                int j;
                for (j = 1; j <= nVerts - 1; j++)
                    if (!(vertexList[j].isInTree) && sPath[j].distance < minDist)
                    {
                        minDist = sPath[j].distance;
                        indexMin = j;
                    }
                return indexMin;
            }
            public void AdjustShortPath()
            {
                int column = 1;
                while (column < nVerts)
                    if (vertexList[column].isInTree)
                        column++;
                    else
                    {
                        int currentToFring = adjMat[currentVert, column];
                        int startToFringe = startToCurrent + currentToFring;
                        int sPathDist = sPath[column].distance;
                        if (startToFringe < sPathDist)
                        {
                            sPath[column].parentVert = currentVert;
                            sPath[column].distance = startToFringe;
                        }
                        column++;
                    }
            }

            public void DisplayPaths()
            {
                for (int j = 0; j <= nVerts - 1; j++)
                {
                    Console.Write(vertexList[j].label + "=");
                    if (sPath[j].distance == infinity)
                        Console.Write("inf");
                    else
                        Console.Write(sPath[j].distance);
                    string parent = vertexList[sPath[j].parentVert].
                    label;
                    Console.Write("(" + parent + ") ");
                }
            }
        }
        class tphcm
        {
            static void Main()
            {
                Graph theGraph = new Graph();
                theGraph.AddVertex("A");
                theGraph.AddVertex("B");
                theGraph.AddVertex("C");
                theGraph.AddVertex("D");
                theGraph.AddVertex("E");
                theGraph.AddVertex("F");
                theGraph.AddVertex("G");
                theGraph.AddEdge(0, 1, 2);
                theGraph.AddEdge(0, 3, 1);
                theGraph.AddEdge(1, 3, 3);
                theGraph.AddEdge(1, 4, 10);
                theGraph.AddEdge(2, 5, 5);
                theGraph.AddEdge(2, 0, 4);
                theGraph.AddEdge(3, 2, 2);
                theGraph.AddEdge(3, 5, 8);
                theGraph.AddEdge(3, 4, 2);
                theGraph.AddEdge(3, 6, 4);
                theGraph.AddEdge(4, 6, 6);
                theGraph.AddEdge(6, 5, 1);
                Console.WriteLine();
                Console.WriteLine("Shortest paths:");
                Console.WriteLine();
                theGraph.Path();
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
