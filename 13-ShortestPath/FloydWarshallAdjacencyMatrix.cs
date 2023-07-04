using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ShortestPath
{
    public class FloydWarshallAdjacencyMatrix
    {
        private static int inf = int.MaxValue;

        public void ShortestPath(int[,] Graph, int Vertices)
        {
            int[,] distance =  new int[Vertices, Vertices];

            for(int i=0; i< Vertices; i++)
            {
                for(int j=0; j < Vertices; j++)
                {
                    distance[i, j] = Graph[i, j];
                }
            }

            for(int v=0; v< Vertices; v++)
            {
                for (int row = 0; row < Vertices; row++)
                {
                    for (int col = 0; col < Vertices; col++)
                    {
                        if (distance[row, v] != inf && distance[v, col] != inf &&
                            distance[row, v] + distance[v, col] < distance[row, col])
                        {
                            distance[row, col] = distance[row, v] + distance[v, col];
                        }
                    }
                }    
            }

            Print(distance, Vertices);
        }

        private void Print(int[,] distance, int vertices)
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (distance[i, j] == inf)
                        Console.Write("INF ");
                    else
                        Console.Write(distance[i, j] + "   ");
                }

                Console.WriteLine();
            }
        }
    }
}
