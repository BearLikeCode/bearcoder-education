from collections import deque

def bfs(graph, start):
    visited = set()            # Множина для відвіданих вершин
    queue = deque([start])     # Черга для обробки вершин

    while queue:
        vertex = queue.popleft()    # Беремо вершину з початку черги
        if vertex not in visited:
            print(vertex)          # Обробляємо вершину
            visited.add(vertex)    # Позначаємо вершину як відвідану
            for neighbor in graph[vertex]:
                if neighbor not in visited:
                    queue.append(neighbor)   # Додаємо всі непомічені сусідні вершини до черги

# Приклад графа у форматі списку сусідів
graph = {
    'A': ['B', 'C'],
    'B': ['A', 'D', 'E'],
    'C': ['A', 'F'],
    'D': ['B'],
    'E': ['B', 'F'],
    'F': ['C', 'E']
}

# Запуск BFS з початковою вершиною 'A'
bfs(graph, 'A')

