using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ShortestPath
{
    public class DijkstraAdjacencyList
    {
        private int VerticesCount;
        private List<(int, int)>[] AdjacencyList;

        public DijkstraAdjacencyList(int verticesCount)
        {
            VerticesCount = verticesCount;
            AdjacencyList = new List<(int, int)>[VerticesCount];

            for(int i =0; i< verticesCount; i++)
            {
                AdjacencyList[i] = new List<(int, int)>();
            }
        }

        public void AddEdge(int source, int destination, int weight)
        {
            AdjacencyList[source].Add((destination, weight));
        }

        public void FindShortestPath(int source)
        {
            int[] distance =  new int[VerticesCount];
            bool[] visisted = new bool[VerticesCount];
            int[] previousNode = new int[VerticesCount];

            for (int i=0; i<VerticesCount; i++)
            {
                distance[i] = int.MaxValue;
                visisted[i] = false;
                previousNode[i] = -1;
            }

            distance[source] = 0;

            for(int count = 0; count < VerticesCount -1; count++)
            {
                int minDistance = MinimumDistance(distance, visisted);
                visisted[minDistance]= true;   

                foreach (var edge in AdjacencyList[minDistance])
                {
                    int destination = edge.Item1;
                    int weight = edge.Item2;

                    if (!visisted[destination] && distance[minDistance] != int.MaxValue 
                        &&  distance[minDistance] + weight < distance[destination])
                    {
                        distance[destination] = distance[minDistance] + weight;
                        previousNode[destination] = minDistance;
                    }
                }
            }

            Print(distance, previousNode);
        }
        
        private int MinimumDistance(int[] distance, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int minIndex = 0;

            for(int v = 0; v < VerticesCount; v++)
            {
                if (visited[v] == false && distance[v] <= minDistance) 
                {
                    minDistance = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private void Print(int[] distance, int[] previousNode)
        {
            Console.WriteLine("Vertex Distance from Source");
            for(int i =0;i < VerticesCount; i++)
            {
                Console.WriteLine("Node : " + i + " Distance : " + distance[i] + " Previous Node : " + previousNode[i]);
            }
        }
    }
}
