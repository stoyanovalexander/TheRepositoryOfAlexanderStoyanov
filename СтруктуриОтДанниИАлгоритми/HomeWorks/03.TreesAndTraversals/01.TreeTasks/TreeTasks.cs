using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TreeTasks
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            // 1. Find the root
            var root = FindRoot(nodes);
            Console.WriteLine("THE ROOT OF THE TREE IS: {0}", root.Value);

            // 2. Find all leafs 
            // I only remove the last ","
            var leafs = FindAllLeafs(nodes);
            Console.Write("LEAFS: ");
            //foreach (var leaf in leafs)
            for (int i = 0; i < leafs.Count-1;i++ )
            {
                Console.Write("{0}, ", leafs[i].Value);
            }

            Console.Write(leafs[leafs.Count-1].Value);
            Console.WriteLine();

            // 3. Find all middle nodes
            // I Only remove the last ","
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("MIDDLENODES: ");
            //foreach (var node in middleNodes)
            for (int i = 0; i < middleNodes.Count-1;i++ )
            {
                Console.Write("{0}, ", middleNodes[i].Value);
            }
            Console.Write(middleNodes[middleNodes.Count-1].Value);
            Console.WriteLine();

            // 4. Find the longest path from the root
            //
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("LONGEST PATH: {0}", longestPath );
        }
        

        // Task.1: FindTheRoot byNikky 
        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The tree has no root.");
        }

        // Task.2: FindAllLeaves by Niky
        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        // Task.3 FindAllMiddleNodes by Nikky
        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        // Task.4 FindLongestPath by Nikky
        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }
    }


