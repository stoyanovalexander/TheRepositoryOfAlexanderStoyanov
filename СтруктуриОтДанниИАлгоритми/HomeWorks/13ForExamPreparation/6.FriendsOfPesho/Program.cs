using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace FriendsOfPesho
{
    public class Friends
    {
        static void Main()
        {
            string[] counters = Console.ReadLine().Split(' ');

            int streetsCount = int.Parse(counters[1]);

            string[] hospitals = Console.ReadLine().Split(' ');

            Dictionary<int, Node> uniqueNodes = new Dictionary<int, Node>();
            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();

            for (int i = 0; i < streetsCount; i++)
            {
                string[] connection = Console.ReadLine().Split(' ');

                int firstNode = int.Parse(connection[0]);
                int secondNode = int.Parse(connection[1]);
                int distance = int.Parse(connection[2]);

                if (!uniqueNodes.ContainsKey(firstNode))
                {
                    Node firstUniqueNode = new Node(firstNode);
                    uniqueNodes.Add(firstNode, firstUniqueNode);
                }

                if (!uniqueNodes.ContainsKey(secondNode))
                {
                    Node secondUniqueNode = new Node(secondNode);
                    uniqueNodes.Add(secondNode, secondUniqueNode);
                }

                if (!graph.ContainsKey(uniqueNodes[firstNode]))
                {
                    graph.Add(uniqueNodes[firstNode], new List<Connection>());
                }

                if (!graph.ContainsKey(uniqueNodes[secondNode]))
                {
                    graph.Add(uniqueNodes[secondNode], new List<Connection>());
                }

                graph[uniqueNodes[firstNode]].Add(new Connection(uniqueNodes[secondNode], distance));
                graph[uniqueNodes[secondNode]].Add(new Connection(uniqueNodes[firstNode], distance));
            }

            List<int> allHospitals = new List<int>();

            for (int i = 0; i < hospitals.Length; i++)
            {
                int someHospital = int.Parse(hospitals[i]);
                allHospitals.Add(someHospital);
                uniqueNodes[someHospital].IsHospital = true;
            }

            long minDijkstra = long.MaxValue;

            for (int i = 0; i < allHospitals.Count; i++)
            {
                DijkstraAlgorithm(graph, uniqueNodes[allHospitals[i]]);

                long sum = 0;

                foreach (var item in uniqueNodes)
                {
                    if (!item.Value.IsHospital)
                    {
                        sum += item.Value.DijkstraDistance;
                    }
                }

                if (sum < minDijkstra)
                {
                    minDijkstra = sum;
                }
            }

            Console.WriteLine(minDijkstra);
        }

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
    }
}

namespace FriendsOfPesho
{
    public class Node : IComparable
    {
        public int ID { get; private set; }
        public long DijkstraDistance { get; set; }
        public bool IsHospital { get; set; }

        public Node(int id)
        {
            this.ID = id;
            this.IsHospital = false;
        }

        public int CompareTo(object obj)
        {
            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }
}

namespace FriendsOfPesho
{
    public class Connection
    {
        public Node ToNode { get; set; }
        public long Distance { get; set; }

        public Connection(Node node, long distance)
        {
            this.ToNode = node;
            this.Distance = distance;
        }
    }
}

namespace FriendsOfPesho
{
    public class PriorityQueue<T> where T : IComparable
    {
        private T[] heap;
        private int index;

        public int Count
        {
            get
            {
                return this.index - 1;
            }
        }

        public PriorityQueue()
        {
            this.heap = new T[16];
            this.index = 1;
        }

        public void Enqueue(T element)
        {
            if (this.index >= this.heap.Length - 1)
            {
                IncreaseArray();
            }

            this.heap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = childIndex / 2;
            this.index++;

            while (parentIndex >= 1 && this.heap[childIndex].CompareTo(this.heap[parentIndex]) < 0)
            {
                T swapValue = this.heap[parentIndex];
                this.heap[parentIndex] = this.heap[childIndex];
                this.heap[childIndex] = swapValue;

                childIndex = parentIndex;
                parentIndex = childIndex / 2;
            }
        }

        public T Dequeue()
        {
            T result = this.heap[1];

            this.heap[1] = this.heap[this.Count];
            this.index--;

            int rootIndex = 1;

            int minChild;

            while (true)
            {
                int leftChildIndex = rootIndex * 2;
                int rightChildIndex = rootIndex * 2 + 1;

                if (leftChildIndex > this.index)
                {
                    break;
                }
                else if (rightChildIndex > this.index)
                {
                    minChild = leftChildIndex;
                }
                else
                {
                    if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) < 0)
                    {
                        minChild = leftChildIndex;
                    }
                    else
                    {
                        minChild = rightChildIndex;
                    }
                }

                if (this.heap[minChild].CompareTo(this.heap[rootIndex]) < 0)
                {
                    T swapValue = this.heap[rootIndex];
                    this.heap[rootIndex] = this.heap[minChild];
                    this.heap[minChild] = swapValue;

                    rootIndex = minChild;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public T Peek()
        {
            return this.heap[1];
        }

        private void IncreaseArray()
        {
            T[] copiedHeap = new T[this.heap.Length * 2];

            for (int i = 0; i < this.heap.Length; i++)
            {
                copiedHeap[i] = this.heap[i];
            }

            this.heap = copiedHeap;
        }
    }
}