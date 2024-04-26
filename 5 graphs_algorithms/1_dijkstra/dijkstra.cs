.using System;
using System.Collections.Generic;

class Dijkstra
{
    public Dictionary<char, int> ShortestDistances(Dictionary<char, Dictionary<char, int>> graph, char start)
    {
        Dictionary<char, int> distances = new Dictionary<char, int>();
        foreach (char node in graph.Keys)
        {
            distances[node] = int.MaxValue; // Initialize distances to infinity
        }
        distances[start] = 0; // Distance from start to itself is 0

        SortedSet<(int, char)> priorityQueue = new SortedSet<(int, char)>();
        priorityQueue.Add((0, start));

        while (priorityQueue.Count > 0)
        {
            (int currentDistance, char currentNode) = priorityQueue.Min;
            priorityQueue.Remove(priorityQueue.Min);

            // If current distance is greater than the known shortest distance, skip
            if (currentDistance > distances[currentNode])
            {
                continue;
            }

            // Update distances to neighbors through current node
            foreach (var neighbor in graph[currentNode])
            {
                char neighborNode = neighbor.Key;
                int weight = neighbor.Value;
                int distance = currentDistance + weight;
                if (distance < distances[neighborNode])
                {
                    distances[neighborNode] = distance;
                    priorityQueue.Add((distance, neighborNode));
                }
            }
        }

        return distances;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, Dictionary<char, int>> graph = new Dictionary<char, Dictionary<char, int>>
        {
            {'A', new Dictionary<char, int> { {'B', 3}, {'C', 2} }},
            {'B', new Dictionary<char, int> { {'A', 3}, {'C', 1}, {'D', 6} }},
            {'C', new Dictionary<char, int> { {'A', 2}, {'B', 1}, {'D', 4} }},
            {'D', new Dictionary<char, int> { {'B', 6}, {'C', 4} }}
        };

        Dijkstra dijkstra = new Dijkstra();
        char startNode = 'A';
        Dictionary<char, int> distances = dijkstra.ShortestDistances(graph, startNode);

        // Print shortest distances from start node to all other nodes
        foreach (var node in distances)
        {
            Console.WriteLine($"Shortest distance from {startNode} to {node.Key}: {node.Value}");
        }
    }
}
