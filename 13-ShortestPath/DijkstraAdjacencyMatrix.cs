using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ShortestPath
{
    public class DijkstraAdjacencyMatrix
    {

        private int VerticesCount;
        private int[,] Graph;

        public void FindShortestPath(int[,] Matrix, int Source)
        {
            VerticesCount = Matrix.GetLength(0);
            Graph = Matrix;

            int[] distance = new int[VerticesCount];
            bool[] visited = new bool[VerticesCount];
            int[] previousNode = new int[VerticesCount];

            for (int i = 0; i < VerticesCount; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
                previousNode[i] = -1;
            }

            distance[Source] = 0;

            for(int count=0; count < VerticesCount - 1; count++) 
            {
                int minDistance = MinDistance(distance, visited);
                visited[minDistance] = true;

                for(int i= 0; i < VerticesCount; i++)
                {
                    if (!visited[i] && Graph[minDistance,i] != 0 && distance[minDistance] != int.MaxValue &&
                        distance[minDistance] + Graph[minDistance, i] < distance[i])
                    {
                        distance[i] = distance[minDistance] + Graph[minDistance, i];
                        previousNode[i] = minDistance;
                    }
                }
            }

            Print(distance, previousNode);
        }

        private int MinDistance(int[] distance, bool[] visisted)
        {
            int min = int.MaxValue;
            int minIndex = -1;
             
            for(int i = 0; i < VerticesCount; i++)
            {
                if (!visisted[i] && distance[i] <= min)
                {
                    min = distance[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private void Print(int[] distance, int[] previousNode)
        {
            for(int i=0;i < VerticesCount; i++)
            {
                Console.WriteLine("Node : " + i + " Distance : " + distance[i] + " Previous Node : " + previousNode[i]);
            }
        }
    }
}
