using System;
using CSharpDataStructuresAlgorithms.Queues;

namespace CSharpDataStructuresAlgorithms.Graphs
{
    public class Graph
    {
        private int vertices;
        private int[,] adjMatrix;
        int[] visited;

        // n = number of vertices
        public Graph(int n)
        {
            vertices = n;
            adjMatrix = new int[n,n];
            visited = new int[vertices];
        }

        public void insertEdge(int u, int v, int x)
        {
            adjMatrix[u, v] = x;
        }

        public void removeEdge(int u, int v)
        {
            adjMatrix[u, v] = 0;
        }

        public bool existEdge(int u, int v)
        {
            return adjMatrix[u, v] != 0;
        }

        public int vertexCount()
        {
            return vertices;
        }

        public int edgeCount()
        {
            int count = 0;
            for(int i=0; i<vertices; i++)
            {
                for(int j=0; j<vertices; j++)
                {
                    if(adjMatrix[i,j] != 0)
                        count++;
                }
            }

            return count;
        }

        public void edges()
        {
            Console.WriteLine("Edges:");
            for(int i=0; i<vertices; i++)
            {
                for(int j=0; j<vertices; j++)
                {
                    if(adjMatrix[i,j] != 0)
                        Console.WriteLine($"{i} ------ {j}");
                }
            }
        }

        public int outDegree(int v)
        {
            int count = 0;
            for(int j=0; j<vertices; j++)
            {
                if(adjMatrix[v,j] != 0) count++;
            }

            return count;
        }

        public int inDegree(int v)
        {
            int count = 0;
            for(int i=0; i<vertices; i++)
            {
                if(adjMatrix[i,v] != 0) count++;
            }

            return count;
        }

        public void display()
        {
            for(int i=0; i<vertices; i++)
            {
                for(int j=0; j<vertices; j++)
                {
                    Console.Write($"{adjMatrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        // Breadth-First Search
        // s - start vertex
        public void BFS(int s)
        {
            int i = s;
            QueueLinkedList<int> q = new QueueLinkedList<int>();
            int[] visited = new int[vertices];
            Console.Write(i + " ");
            visited[i] = 1;
            q.enqueue(i);

            while(!q.isEmpty())
            {
                i = q.dequeue();
                for(int j=0; j<vertices; j++)
                {
                    if(adjMatrix[i,j] == 1 && visited[j] == 0)
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;
                        q.enqueue(j);
                    }
                }
            }
        }

        // Depth-first Search
        public void DFS(int s)
        {
            if(visited[s] == 0) 
            {
                Console.Write(s + " ");
                visited[s] = 1;
                for(int j=0; j<vertices; j++)
                {
                    if(adjMatrix[s,j] == 1 && visited[j] == 0)
                    {
                        DFS(j);
                    }
                }
            }


        }
    }
}