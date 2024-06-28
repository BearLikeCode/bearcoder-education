const graph = {};
graph.a = {b: 2, c: 1};
graph.b = {f: 7};
graph.c = {d: 5, e: 2};
graph.d = {f: 2};
graph.e = {f: 1};
graph.f = {g: 1};
graph.g = {}

function shortPath(graph, start, end) {
    const costs = {};
    const processed = [];
    let neighbours = {};
    Object.keys(graph).forEach(node => {
        if(node !== start) {
            let value = graph[start][node];
            costs[node] = value || 10000000;
        }
    })
    let node = findNodeLowestCost(costs, processed)
    while (node) {
        const cost = costs[node];
        neighbours = graph[node];
        Object.keys(neighbours).forEach(neighbour => {
            let newCost = cost + neighbours[neighbour]
            if (newCost < costs[neighbour]) {
                costs[neighbour] = newCost;
            }
        })
        processed.push(node);
        node = findNodeLowestCost(costs, processed); 
    }
    return lowestNode;
}

function findNodeLowestCost(costs, processed) {
    let lowestCost = 10000000;
    let lowestNode;
    Object.keys(costs).forEach(node => {
        let cost = costs[node];
        if (cost < lowestCost && !processed.includes(node)) {
            lowestCost = cost;
            lowestNode = node;
        }
    })
    return lowestNode;
}

console.log(shortPath(graph, 'a', 'g'))