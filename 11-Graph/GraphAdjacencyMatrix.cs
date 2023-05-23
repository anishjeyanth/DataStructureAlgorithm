using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class GraphAdjacencyMatrix
    {
        public int[,] Matrix;
        private int VertexCount;

        public GraphAdjacencyMatrix(int vertex)
        {
            VertexCount = vertex;
            Matrix = new int[VertexCount, VertexCount];
        }

        public void AddEdge(int v1, int v2)
        {
            Matrix[v1, v2] = 1;
            Matrix[v2, v1] = 1;
        }

        public void RemoveEdge(int v1, int v2)
        {
            Matrix[v1, v2] = 0;
            Matrix[v2, v1] = 0;
        }

        public void DisplayMatrix()
        {
            string[] letter = { "A", "B", "C", "D", "E", "F", "G" };

            for (int i = 0; i < VertexCount; i++)
            {
                Console.Write(letter[i] + " ");
                for (int j = 0; j < VertexCount; j++)
                {
                    Console.Write(Matrix[i, j] + " - ");                
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void BFS(int start)
        {
            bool[] visisted = new bool[VertexCount];
            Queue<int> queue = new Queue<int>();

            visisted[start] = true;
            queue.Enqueue(start);

            while(queue.Any())
            {
                int vertex = queue.Dequeue();
                Console.Write(vertex+ " - ");

                for(int i=0; i< VertexCount; i++)
                {
                    if (Matrix[vertex,i] == 1 && !visisted[i])
                    {
                        visisted[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }

            Console.WriteLine();
        }

        public void DFS(int start)
        {
            bool[] visited = new bool[VertexCount];
            DFSR(start, visited);

            for (int i = 0; i < VertexCount; i++)
            {
                if (!visited[i])
                    DFSR(i, visited);
            }

            Console.WriteLine();
        }

        private void DFSR(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " - ");

            for(int i = 0; i < VertexCount; i++)
            {
                if (Matrix[vertex, i] == 1 && !visited[i])
                    DFSR(i, visited);
            }
        }
    }
}
