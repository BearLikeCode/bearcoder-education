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

        BFS(graph, 'A');
    }

    static void BFS(Dictionary<char, List<char>> graph, char start)
    {
        HashSet<char> visited = new HashSet<char>(); // Множина для відвіданих вершин
        Queue<char> queue = new Queue<char>();      // Черга для обробки вершин

        queue.Enqueue(start);                       // Додаємо початкову вершину у чергу

        while (queue.Count > 0)
        {
            char vertex = queue.Dequeue();          // Беремо вершину з початку черги
            if (!visited.Contains(vertex))
            {
                Console.WriteLine(vertex);         // Обробляємо вершину
                visited.Add(vertex);               // Позначаємо вершину як відвідану
                foreach (char neighbor in graph[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);   // Додаємо всі непомічені сусідні вершини у чергу
                    }
                }
            }
        }
    }
}

