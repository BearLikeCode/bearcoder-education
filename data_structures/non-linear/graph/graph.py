# The Graph class uses an adjacency list to represent an undirected graph.
# The add_edge method adds an undirected edge between two vertices.
# The display method prints the graph representation, showing each vertex and its neighbors.
# The example usage creates a graph with vertices 1, 2, 3, 4, and 5, and adds edges to create a simple undirected graph. The display method is then called to print the graph representation.

from collections import defaultdict

class Graph:
    def __init__(self):
        self.graph = defaultdict(list)

    def add_edge(self, u, v):
        self.graph[u].append(v)
        self.graph[v].append(u)

    def display(self):
        for vertex, neighbors in self.graph.items():
            print(f"Vertex {vertex}: {neighbors}")

# Example usage of the graph
graph = Graph()

graph.add_edge(1, 2)
graph.add_edge(1, 3)
graph.add_edge(2, 3)
graph.add_edge(2, 4)
graph.add_edge(3, 4)
graph.add_edge(4, 5)

print("Graph Representation:")
graph.display()
