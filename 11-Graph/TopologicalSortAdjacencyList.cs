using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class TopologicalSortAdjacencyList
    {
        private int Vertices;
        private List<int>[] AdjacencyList;

        public TopologicalSortAdjacencyList(int Vertices)
        {
            this.Vertices = Vertices;
            AdjacencyList = new List<int>[Vertices];
            for(int i = 0; i < Vertices; i++)
            {
                AdjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            AdjacencyList[source].Add(destination);
        }

        public void Sort()
        {
            bool[] visited = new bool[Vertices];
            Stack<int> stack = new Stack<int>();

            for(int i=0; i < Vertices; i++)
            {
                if (!visited[i])
                {
                    SortR(i, visited, stack);
                }
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop() + " - ");
            }
        }

        private void SortR(int vertex, bool[] visited, Stack<int> stack)
        {
            visited[vertex] = true;
            foreach(int adj in AdjacencyList[vertex])
            {
                if (!visited[adj])
                    SortR(adj, visited, stack);
            }

            stack.Push(vertex);
        }
    }
}
