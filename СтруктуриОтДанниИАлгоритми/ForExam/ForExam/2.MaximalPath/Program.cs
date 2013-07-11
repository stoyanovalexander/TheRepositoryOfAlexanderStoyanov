using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximalPath
{
    class Program
    {
        static int maxSum = 0;
        static List<Node> usedNodes = new List<Node>();
        static void DFS(Node node, int currentSum)
        {
            currentSum += node.Value;
            usedNodes.Add(node);

            for (int i = 0; i < node.NumberOfChildren; i++)
            {
                if (usedNodes.Contains(node.GetChild(i)))
                {
                    continue;
                }

                DFS(node.GetChild(i), currentSum);
            }

            if (node.NumberOfChildren == 1 && currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            for (int i = 0; i < N - 1; i++)
            {
                string connection = Console.ReadLine();
                string[] separatedConection = connection.Split(new char[] {'(',')','<','-',' '},StringSplitOptions.RemoveEmptyEntries);
                int parent = int.Parse(separatedConection[0]);
                int child = int.Parse(separatedConection[1]);
            

                Node parentNode;
                Node childNode=new Node(0);

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                }
                else
                {
                    parentNode = new Node(parent);
                    nodes.Add(parent,parentNode);
                }

                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    parentNode.AddChild(childNode);
                    childNode.AddChild(parentNode);
                }

                foreach (var node in nodes)
                { 
                    if(node.Value.NumberOfChildren==1)
                    {
                        usedNodes.Clear();
                        DFS(node.Value,0);
                    }
                }
               
            }
            Console.WriteLine(maxSum);

        }

        public class Node
        {
            private int value;
            public bool hasParent{get;set;}
            private List<Node> children;

            public Node(int value)
            {
                this.value = value;
                this.children = new List<Node>();
            }

            public int Value
            {
                get { return this.value; }
            }

            public int NumberOfChildren
            {
                get { return this.children.Count; }
            }

            public void AddChild(Node child)
            {
                child.hasParent = true;
                children.Add(child);
            }

            public Node GetChild(int index)
            {
                return this.children[index];
            }
        }
    }
}
