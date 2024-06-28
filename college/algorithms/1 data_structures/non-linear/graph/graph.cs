// The Graph class uses a Dictionary<int, List<int>> to represent an undirected graph with an adjacency list.
// The AddEdge method adds an undirected edge between two vertices.
// The Display method prints the graph representation, showing each vertex and its neighbors.
// The example usage creates a graph with vertices 1, 2, 3, 4, and 5, and adds edges to create a simple undirected graph. The Display method is then called to print the graph representation.

using System;
using System.Collections.Generic;

class Graph
{
    private Dictionary<int, List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int u, int v)
    {
        if (!adjacencyList.ContainsKey(u))
            adjacencyList[u] = new List<int>();
        
        if (!adjacencyList.ContainsKey(v))
            adjacencyList[v] = new List<int>();

        adjacencyList[u].Add(v);
        adjacencyList[v].Add(u);
    }

    public void Display()
    {
        foreach (var vertex in adjacencyList.Keys)
        {
            Console.Write($"Vertex {vertex}: ");
            foreach (var neighbor in adjacencyList[vertex])
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the graph
        Graph graph = new Graph();

        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);

        Console.WriteLine("Graph Representation:");
        graph.Display();
    }
}
