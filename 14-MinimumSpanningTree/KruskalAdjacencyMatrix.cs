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

        private int Find(int[] visited, int vertex)
        {
            if (visited[vertex] == -1)
                return vertex;

            return Find(visited, visited[vertex]);
        }

        private void Union(int[] visited, int source, int destination)
        {
            int sou = Find(visited, source);
            int des = Find(visited, destination);
            visited[sou] = des;
        }

        public void MST()
        {
            Edge[] edges = new Edge[Vertices * Vertices];
            int edgeCount = 0;

            for(int i = 0; i < Vertices; i++)
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

            Edge[] edge = edges.Where(x => x != null).ToArray<Edge>();
            System.Array.Sort(edge, (e1,e2) => e1.Weight.CompareTo(e2.Weight));

            Edge[] result = new Edge[Vertices - 1];
            int[] visited = new int[Vertices];

            for (int i = 0; i < Vertices; i++)
                visited[i] = -1;

            int count = 0;
            int index = 0;
            while(count < Vertices - 1)
            {
                Edge nextEdge = edge[index++];
                int sou = Find(visited, nextEdge.Source);
                int des = Find(visited, nextEdge.Destination);

                if (sou != des)
                {
                    result[count] = nextEdge;
                    Union(visited, sou, des);
                    count++;
                }
            }

            foreach(Edge edg in result)
            {
                Console.WriteLine(" Source -" + edg.Source + " Destination -" + edg.Destination + " Weight -" + edg.Weight);
            }
        }
    }
}
