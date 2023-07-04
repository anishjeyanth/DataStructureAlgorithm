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
            this.Vertices = Vertices;
            AdjacencyMatrix = new int[Vertices, Vertices];
        }

        public void AddEdge(int source, int destination, int weight)
        {
            AdjacencyMatrix[source, destination] = weight;
            AdjacencyMatrix[destination, source] = weight;
        }

        public void MST()
        {
            bool[] visited = new bool[Vertices]; // Array to track vertices included in MST
            int[] parent = new int[Vertices]; // Array to store the parent of each vertex
            int[] key = new int[Vertices]; // Array to store the minimum weight edge for each vertex

            for (int i=0;i < Vertices; i++)
            {
                key[i] = int.MaxValue;
                visited[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for(int count = 0; count < Vertices - 1; count++)
            {
                int sou = MinKey(key, visited);
                visited[sou] = true;

                for (int col = 0; col < Vertices; col++)
                {
                    if (!visited[col] && AdjacencyMatrix[sou, col] != 0 && AdjacencyMatrix[sou, col] < key[col])
                    {
                        parent[col] = sou;
                        key[col] = AdjacencyMatrix[sou, col];
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
                Console.WriteLine($"Source - {parent[i]} Destination - {i}  Weight - {key[i]}");
            }
        }
    }
}
