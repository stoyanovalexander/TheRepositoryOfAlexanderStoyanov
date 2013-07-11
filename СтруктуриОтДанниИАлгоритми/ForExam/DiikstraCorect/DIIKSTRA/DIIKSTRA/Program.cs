public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();
 
            foreach (var item in graph)
            {
                item.Key.DijkstraDistance = long.MaxValue;
            }
 
            queue.Enqueue(source);
            source.DijkstraDistance = 0;
 
            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();
 
                foreach (var connection in graph[currentNode])
                {
                    var potDistance = connection.Distance + currentNode.DijkstraDistance;
 
                    if (potDistance < connection.ToNode.DijkstraDistance)
                    {
                        connection.ToNode.DijkstraDistance = potDistance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }