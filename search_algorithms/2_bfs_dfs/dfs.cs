using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>
        {
            { 'A', new List<char> { 'B', 'C' } },
            { 'B', new List<char> { 'A', 'D', 'E' } },
            { 'C', new List<char> { 'A', 'F' } },
            { 'D', new List<char> { 'B' } },
            { 'E', new List<char> { 'B', 'F' } },
            { 'F', new List<char> { 'C', 'E' } }
        };

        DFS(graph, 'A');
    }

    static void DFS(Dictionary<char, List<char>> graph, char start)
    {
        HashSet<char> visited = new HashSet<char>(); // Множина для відвіданих вершин
        DFSUtil(graph, start, visited);
    }

    static void DFSUtil(Dictionary<char, List<char>> graph, char vertex, HashSet<char> visited)
    {
        visited.Add(vertex);       // Позначаємо вершину як відвідану
        Console.WriteLine(vertex); // Виводимо вершину

        foreach (char neighbor in graph[vertex])
        {
            if (!visited.Contains(neighbor))
            {
                DFSUtil(graph, neighbor, visited); // Рекурсивно викликаємо DFS для непомічених сусідів
            }
        }
    }
}

