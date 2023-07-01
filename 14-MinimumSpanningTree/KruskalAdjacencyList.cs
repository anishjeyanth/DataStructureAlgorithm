using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            List<Edge> minimumSpanningTree = new List<Edge>();

            Edges.Sort((e1,e2) => e1.Weight.CompareTo(e2.Weight));

            int[] visited = new int[Vertices];
            for (int i = 0; i < Vertices; i++)
                visited[i] = -1;

            int edgeCount = 0;
            int index = 0;
            while(edgeCount < Vertices - 1)
            {
                Edge nextEdge = Edges[index++];
                int sou = Find(visited, nextEdge.Source);
                int des = Find(visited, nextEdge.Destination);

                if (sou != des)
                {
                    minimumSpanningTree.Add(nextEdge);
                    Union(visited, sou, des);
                    edgeCount++;
                }
            }

            foreach(Edge edge in minimumSpanningTree)
            {
                Console.WriteLine(" Source -" + edge.Source + " Destination -" + edge.Destination + " Weight -" + edge.Weight);
            }
        }
    }
}
