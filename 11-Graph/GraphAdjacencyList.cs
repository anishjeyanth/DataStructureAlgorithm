using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class GraphAdjacencyList
    {
        private int Vertices;
        private List<int>[] Adjacency;

        public GraphAdjacencyList(int vertices)
        {
            Vertices = vertices;
            Adjacency = new List<int>[Vertices];

            for(int i=0;i< Vertices;i++)
                Adjacency[i] = new List<int>();
        }

        public void AddEdge(int vertex1, int vertex2)
        {
            Adjacency[vertex1].Add(vertex2);
        }

        public void DFS(int v)
        {
            bool[] visisted = new bool[Vertices];
            DFSR(v, visisted);
        }

        private void DFSR(int v, bool[] visisted)
        {
            visisted[v] = true;
            Console.Write(v + " - ");
            foreach(int i in Adjacency[v])
            {
                if (!visisted[i])
                    DFSR(i, visisted);
            }
        }

        public void BFS(int s)
        {
            bool[] visisted = new bool[Vertices];
            visisted[s] = true;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);

            while(queue.Count > 0)
            {
                s = queue.Dequeue();
                Console.Write(s + " - ");
                foreach(int i in Adjacency[s])
                {
                    if (!visisted[i])
                    {
                        visisted[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}
