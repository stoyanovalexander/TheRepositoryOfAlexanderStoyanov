using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TreeTasksDifferentWay
    {
        // Method for Task.1: FindTheRoot
        public static int FindRoot(int[] children, int N)
        {
            bool[] isRoot = new bool[N];
            for (int i = 0; i < isRoot.Length; i++)
            {
                isRoot[i] = true;
            }

            int root=-5;
            for (int i = 0; i < N ; i++)
            {
                for (int j = 0; j < children.Count(); j++)
                {
                    if (i == children[j])
                    {
                        isRoot[i] = false;
                    }
                }
            }

            for (int i = 0; i < isRoot.Length; i++)
            {
                if (isRoot[i])
                {
                    root =i;
                }
            }

            return root;
        }

        // Method for Task.2: FindTheLeafs
        public static List<int> FindLeafs(int[] parents, int N)
        {
            bool[] isLeaf = new bool[N];
            for (int i = 0; i < isLeaf.Length; i++)
            {
                isLeaf[i] = true;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < parents.Length; j++)
                {
                    if (i == parents[j])
                    {
                        isLeaf[i] = false;
                    }
                }
            }

            List<int> leafs = new List<int>();
            for (int i = 0; i < isLeaf.Length; i++)
            {
                if (isLeaf[i])
                {
                    leafs.Add(i);
                }
            }

            return leafs;
        }

        // Method for Task.3: FindTheMiddleNodes 
        public static List<int> FindMiddleNodes(int[] parents,int[] children, int N)
        {
            bool[] isMiddle=new bool[N];
            for (int i = 0; i < N; i++)
            {
                isMiddle[i] = true;
            }

            int root = FindRoot(children, N);
            isMiddle[root] = false;

            List<int> isLeaf = FindLeafs(parents, N);
            for (int i = 0; i < isLeaf.Count(); i++)
            {
                isMiddle[isLeaf[i]] = false;
            }

            List<int> middleNodes=new List<int>();
            for (int i = 0; i < isMiddle.Length; i++)
            {
                if (isMiddle[i])
                {
                    middleNodes.Add(i);
                }
            }

            return middleNodes;
        }

        // Method for Task.4: FindLongestPath
        public static int FindLongestPath(int[] parents, int[] children, int N)
        {
            int pathElement;
            int count = 0;
            int bestLen=0;

            if (children.Length == 0)
            {
                bestLen = 0;
            }
            else
            {
                for (int i = 0; i < parents.Length; i++)
                {
                    pathElement = children[i];
                    count++;
                    for (int j = 0; j < parents.Length; j++)
                    {
                        if (pathElement == parents[j])
                        {
                            pathElement = children[j];
                            count++;
                        }
                    }

                    if (bestLen < count)
                    {
                        bestLen = count;
                    }

                    count = 0;
                }
            }
            return bestLen;
        }

        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            int[] children = new int[N - 1];
            int[] parents = new int[N - 1];

            for (int i = 0; i < N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                parents[i] =int.Parse(edgeParts[0]);
                children[i] =int.Parse(edgeParts[1]);
            }

            // Task.1: TheRoot
            Console.WriteLine();
            Console.WriteLine("THE ROOT IS: "+FindRoot(children,N));

            // Task.2: TheLeafs
            Console.WriteLine();
            List<int> leafs = FindLeafs(parents, N);
            Console.Write("LEAFS: ");
            for (int i = 0; i < leafs.Count - 1; i++)
            {
                Console.Write("{0}, ", leafs[i]);
            }

            Console.Write(leafs[leafs.Count - 1]);
            Console.WriteLine();
            
            // Task.3: TheMiddleNodes 
            Console.WriteLine();
            List<int> middleNodes = FindMiddleNodes(parents,children,N);
            Console.Write("MIDDLE NODES: ");
            for (int i = 0; i < middleNodes.Count - 1; i++)
            {
                Console.Write("{0}, ", middleNodes[i]);
            }

            Console.Write(middleNodes[middleNodes.Count - 1]);
            Console.WriteLine();

            // Task.4: TheLongestPath
            Console.WriteLine();
            Console.Write("LONGEST PATH: "+FindLongestPath(parents,children,N));
            Console.WriteLine();
            Console.WriteLine();
        }
    }

