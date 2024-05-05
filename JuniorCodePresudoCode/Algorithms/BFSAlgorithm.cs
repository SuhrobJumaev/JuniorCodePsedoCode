using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Algorithms
{
    public class BFSAlgorithm
    {
        //GRAPH
        Dictionary<char, List<char>> graph = new()
        {
            { 'A', new () {'G', 'C', 'B'} },
            { 'G', new () {'A'} },
            { 'C', new () {'A','F'}},
            { 'B', new () {'A','D','E'}},
            { 'D', new () {'B','F'}},
            { 'F', new () {'E','D','C'}},
            { 'E', new () {'B','F'}},
        };


        List<char> searchQueue = new();
        List<char> visited = new();

        public void FoundPath(Dictionary<char, List<char>> graph, char fromNode, char toNode)
        {

            bool result = bfs(graph, 'G', 'F');
            Console.WriteLine("Result is " + result);
        }

        private bool bfs(Dictionary<char, List<char>> graph, char start, char end)
        {
            var node = graph[start];

            visited.Add(start);

            searchQueue.AddRange(node);

            while (searchQueue.Count > 0)
            {
                var element = searchQueue.First();
                searchQueue.Remove(element);

                if (!visited.Contains(element))
                {
                    if (element == end)
                    {
                        Console.WriteLine("We found");
                        visited.Add(end);
                        return true;
                    }
                    else
                    {
                        searchQueue.AddRange(graph[element]);
                        visited.Add(element);
                    }
                }
            }

            Console.WriteLine("Not found");
            return false;
        }


    }
}
