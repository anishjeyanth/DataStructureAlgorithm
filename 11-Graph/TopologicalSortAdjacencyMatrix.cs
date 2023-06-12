using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class TopologicalSortAdjacencyMatrix
    {
        private int Vertices;
        private int[,] AdjacencyMatrix;

        public TopologicalSortAdjacencyMatrix(int vertices)
        {
            Vertices = vertices;
            AdjacencyMatrix = new int[vertices, vertices];
        }

        public void AddEdge(int source, int destination)
        {
            AdjacencyMatrix[source, destination] = 1;
        }

        private void SortR(int vertices, bool[] visited, Stack<int> stack)
        {
            visited[vertices] = true;
            for(int i=0; i < Vertices; i++)
            {
                if (AdjacencyMatrix[vertices,i] ==1 && !visited[i])
                {
                    SortR(i, visited, stack);
                }
            }

            stack.Push(vertices);
        }

        public void Sort()
        {
            bool[] visited = new bool[Vertices];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < Vertices; i++)
            {
                if (!visited[i])
                {
                    SortR(i, visited, stack);
                }
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop() + " - ");
            }
        }
    }
}
