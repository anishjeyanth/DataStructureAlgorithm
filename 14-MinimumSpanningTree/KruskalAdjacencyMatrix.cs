using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DSA.MinimumSpanningTree
{
    public class KruskalAdjacencyMatrix
    {
        private int Vertices;
        private int[,] AdjacencyMatrix;

        public KruskalAdjacencyMatrix(int vertices)
        {
            Vertices = vertices;
            AdjacencyMatrix = new int[vertices, vertices];
        }

        public void AddEdge(int source, int desination, int weight)
        {
            AdjacencyMatrix[source, desination] = weight;
            AdjacencyMatrix[desination, source] = weight;
        }

        private int Find(int[] parent, int vertex)
        {
            if (parent[vertex] == -1)
                return vertex;

            return Find(parent, parent[vertex]);
        }

        private void Union(int[] parent, int x, int y)
        {
            int xx = Find(parent, x);
            int yy = Find(parent, y);
            parent[xx] = yy;
        }

        public void MST()
        {
            Edge[] edges = new Edge[Vertices * Vertices];
            int edgeCount = 0;

            for(int i=0; i < Vertices; i++)
            {
                for(int j = i + 1; j < Vertices; j++)
                {
                    if (AdjacencyMatrix[i,j] != 0)
                    {
                        edges[edgeCount] = new Edge
                        {
                            Source = i,
                            Destination = j,
                            Weight = AdjacencyMatrix[i, j]
                        };

                        edgeCount++;
                    }
                }
            }

            System.Array.Sort(edges , (e1,e2) => e1.Weight.CompareTo(e2.Weight));

            Edge[] result = new Edge[Vertices - 1];
            int[] parent = new int[Vertices];

            for (int i = 0; i < Vertices; i++)
                parent[i] = -1;

            int count = 0;
            int index = 0;
            while(count < Vertices - 1)
            {
                Edge nextEdge = edges[index++];
                int x = Find(parent, nextEdge.Source);
                int y = Find(parent, nextEdge.Destination);

                if (x != y)
                {
                    result[count] = nextEdge;
                    Union(parent, x, y);
                    count++;
                }
            }


            foreach(Edge edge in result)
            {
                Console.WriteLine(" Source " + edge.Source + " Destination " + edge.Destination + " Weight " + edge.Weight);
            }
        }
    }
}
