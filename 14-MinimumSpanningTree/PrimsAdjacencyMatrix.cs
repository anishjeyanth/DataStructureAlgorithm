using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.MinimumSpanningTree
{
    public class PrimsAdjacencyMatrix
    {
        private int Vertices;
        private int[,] AdjacencyMatrix;

        public PrimsAdjacencyMatrix(int Vertices)
        {
            Vertices = Vertices;
            AdjacencyMatrix = new int[Vertices, Vertices];
        }

        public void AddEdge(int source, int destination, int weight)
        {
            AdjacencyMatrix[source, destination] = weight;
            AdjacencyMatrix[destination, source] = weight;
        }

        public void MST()
        {
            bool[] visited = new bool[Vertices];
            int[] parent = new int[Vertices];
            int[] key = new int[Vertices];

            for(int i=0;i < Vertices; i++)
            {
                key[i] = int.MaxValue;
                visited[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for(int count = 0; count < Vertices - 1; count++)
            {
                int u = MinKey(key, visited);
                visited[u] = true;

                for (int v = 0; v < Vertices; v++)
                {
                    if (!visited[v] && AdjacencyMatrix[u, v] != 0 && AdjacencyMatrix[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = AdjacencyMatrix[u,v];
                    }
                }
            }

            Print(parent, key);
        }

        private int MinKey(int[] key, bool[] visited)
        {
            int minKey = int.MaxValue;
            int minIndex = -1;
            for(int v = 0; v < Vertices; v++)
            {
                if (!visited[v] && key[v] < minKey) 
                {
                    minKey = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private void Print(int[] parent, int[] key)
        {
            for (int i = 0; i < Vertices; i++)
            {
                Console.WriteLine($"{parent[i]} -- {i}   Weight: {key[i]}");
            }
        }
    }
}
