import heapq

def dijkstra(graph, start):
    # Initialize distances dictionary to store shortest distances from start to all nodes
    distances = {node: float('inf') for node in graph}
    distances[start] = 0  # Distance from start to itself is 0

    # Priority queue to store (distance, node) pairs
    priority_queue = [(0, start)]

    while priority_queue:
        current_distance, current_node = heapq.heappop(priority_queue)

        # If current distance is greater than the known shortest distance, skip
        if current_distance > distances[current_node]:
            continue

        # Update distances to neighbors through current node
        for neighbor, weight in graph[current_node].items():
            distance = current_distance + weight
            if distance < distances[neighbor]:
                distances[neighbor] = distance
                heapq.heappush(priority_queue, (distance, neighbor))

    return distances

# Example graph
graph = {
    'A': {'B': 3, 'C': 2},
    'B': {'A': 3, 'C': 1, 'D': 6},
    'C': {'A': 2, 'B': 1, 'D': 4},
    'D': {'B': 6, 'C': 4}
}

start_node = 'A'
distances = dijkstra(graph, start_node)

# Print shortest distances from start node to all other nodes
for node, distance in distances.items():
    print(f"Shortest distance from {start_node} to {node}: {distance}")
