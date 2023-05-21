using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Graph
{
    public class GraphAdjacencyList
    {
        private Dictionary<string, List<string>> AdjacencyList;

        public GraphAdjacencyList()
        {
            AdjacencyList = new Dictionary<string, List<string>>();
        }

        public void AddVertex(string vertex)
        {
            if (!AdjacencyList.ContainsKey(vertex))
            {
                AdjacencyList.Add(vertex, new List<string>());
            }
        }

        public void AddEdge(string v1, string v2)
        {
            AdjacencyList[v1].Add(v2);
            AdjacencyList[v2].Add(v1);
        }

        public void RemoveEdge(string v1, string v2)
        {
            AdjacencyList[v1].Remove(v2);
            AdjacencyList[v2].Remove(v1);
        }

        public void RemoveVertex(string vertex)
        {
            while (AdjacencyList[vertex].Count > 0)
            {
                string adjacent = AdjacencyList[vertex][AdjacencyList[vertex].Count - 1];
                RemoveEdge(vertex, adjacent);
            }
            AdjacencyList.Remove(vertex);
        }

        public List<string> BFS(string start)
        {
            Queue<string> queue = new Queue<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            string currentVertex;
            visited[start] = true;

            while (queue.Count > 0)
            {
                currentVertex = queue.Dequeue();
                Console.Write(currentVertex + "-");

                foreach (string neighbor in AdjacencyList[currentVertex])
                {
                    if (!visited.ContainsKey(neighbor))
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }

        public void DFSRecursive(string start)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            DFS(start);

            void DFS(string vertex)
            {
                if (vertex == null)
                    return;

                visited[vertex] = true;
                Console.Write(vertex + "-");
                foreach (string neighbout in AdjacencyList[vertex])
                {
                    if (!visited.ContainsKey(neighbout))
                        DFS(neighbout);
                }
            }
        }

        public void DFSIterative(string start)
        {
            Stack<string> stack = new Stack<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            string currentVertex;
            stack.Push(start);
            visited[start] = true;

            while(stack.Count > 0)
            {
                currentVertex = stack.Pop();
                Console.Write(currentVertex + "-");

                foreach (string neighbout in AdjacencyList[currentVertex])
                {
                    if (!visited.ContainsKey(neighbout))
                    {
                        visited[neighbout] = true;
                        stack.Push(neighbout);
                    }
                }
            }
        }
    }
}
