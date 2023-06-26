using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ShortestPath
{
    public class BellmanFordAdjacencyList
    {
        private struct Edge
        {
            public int Source;
            public int Destination;
            public int Weight;
        }

        private int VerticesCount;
        private int EdgeCount;
        private Edge[] Edges;
        private int[] Distance;

        public BellmanFordAdjacencyList(int verticesCount, int edgeCount)
        {
            VerticesCount = verticesCount;
            EdgeCount = edgeCount;
            Edges = new Edge[edgeCount];
            Distance = new int[verticesCount];
        }

        public void AddEdge(int source, int destination, int weight, int edgeIndex)
        {
            Edges[edgeIndex].Source= source;
            Edges[edgeIndex].Destination = destination;
            Edges[edgeIndex].Weight = weight;
        }

        public void FindShortestPath(int source)
        {
            for(int i=0; i < VerticesCount; i++)
            {
                Distance[i] = int.MaxValue;
            }

            Distance[source] = 0;

            for (int i = 0; i < VerticesCount - 1; i++)
            {
                for (int j = 0; j < EdgeCount; j++)
                {
                    int sou = Edges[j].Source;
                    int des = Edges[j].Destination;
                    int weight = Edges[j].Weight;

                    if (Distance[sou] != int.MaxValue && Distance[sou] + weight < Distance[des])
                    {
                        Distance[des] = Distance[sou] + weight;
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
