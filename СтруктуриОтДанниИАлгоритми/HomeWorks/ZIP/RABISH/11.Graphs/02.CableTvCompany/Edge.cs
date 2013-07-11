using System;

    class Edge : IComparable<Edge>
    {
        public int StartNode { get; set; }
        public int EndNode { get; set; }
        public int Distance { get; set; }

        public Edge(int startNode, int endNode, int distance)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Distance = distance;
        }

        public int CompareTo(Edge other)
        {
            int weightCompared = this.Distance.CompareTo(other.Distance);

            if (weightCompared == 0)
            {
                return this.StartNode.CompareTo(other.StartNode);
            }
            return weightCompared;
        }

        public override string ToString()
        {
            return string.Format("({0} {1}) -> {2}", StartNode, EndNode, Distance);
        }
    }

