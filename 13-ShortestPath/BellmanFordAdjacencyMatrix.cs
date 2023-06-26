using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ShortestPath
{
    public class BellmanFordAdjacencyMatrix
    {
        private int VerticesCount;
        private int[,] AdjacencyMatrix;
        private int[] Distance;

        public BellmanFordAdjacencyMatrix(int VerticesCount)
        {
            this.VerticesCount = VerticesCount;
            AdjacencyMatrix = new int[VerticesCount, VerticesCount];
            Distance = new int[VerticesCount];
        }

        public void AddEdge(int source,int destination, int weight)
        {
            AdjacencyMatrix[source, destination] = weight;
        }

        public void FindShortestPath(int source)
        {
            for (int i = 0; i < VerticesCount; i++)
            {
                Distance[i] = int.MaxValue;
            }

            Distance[source] = 0;

            for (int i = 0; i < VerticesCount - 1; i++)
            {
                for (int row = 0; row < VerticesCount; row++)
                {
                    for (int col = 0; col < VerticesCount; col++)
                    {
                        if (AdjacencyMatrix[row,col] != 0 && Distance[row] != int.MaxValue &&
                            Distance[row] + AdjacencyMatrix[row,col] < Distance[col])
                        {
                            Distance[col] = Distance[row] + AdjacencyMatrix[row, col];
                        }
                    }
                }
            }

            for (int i = 0; i < VerticesCount; i++)
            {
                Console.Write(Distance[i] + " | ");
            }
        }
    }
}
