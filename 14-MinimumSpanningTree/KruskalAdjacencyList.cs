using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DSA.MinimumSpanningTree
{
    public class KruskalAdjacencyList
    {
        private int Vertices;
        private List<Edge> Edges;

        public KruskalAdjacencyList(int vertices)
        {
            Vertices = vertices;
            Edges = new List<Edge>();
        }

        public void AddEdge(int source, int desination, int weight)
        {
            Edges.Add(new Edge { Source = source, Destination = desination, Weight = weight });
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
            List<Edge> minimumSpanningTree = new List<Edge>();

            Edges.Sort((e1,e2) => e1.Weight.CompareTo(e2.Weight));

            int[] parent = new int[Vertices];
            for (int i = 0; i < Vertices; i++)
                parent[i] = -1;

            int edgeCount = 0;
            int index = 0;
            while(edgeCount < Vertices - 1)
            {
                Edge nextEdge = Edges[index++];
                int x = Find(parent, nextEdge.Source);
                int y = Find(parent, nextEdge.Destination);

                if (x != y)
                {
                    minimumSpanningTree.Add(nextEdge);
                    Union(parent, x, y);
                    edgeCount++;
                }
            }


            foreach(Edge edge in minimumSpanningTree)
            {
                Console.WriteLine(" Source " + edge.Source + " Destination " + edge.Destination + " Weight " + edge.Weight);
            }
        }
    }
}
