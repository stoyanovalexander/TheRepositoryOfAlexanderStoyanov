using System;
    class Slices
    {
        static void Main(string[] args)
        {
            string whd = Console.ReadLine();
            string[] size = whd.Split(' ');
            int width = int.Parse(size[0]); 
            int height = int.Parse(size[1]); 
            int depth = int.Parse(size[2]);
            long totalSum = 0;
            short[, ,] cub = new short[width, height, depth];

            for (int h = 0; h < height; h++)
            { 
                string line=Console.ReadLine();
                string[] row=line.Split('|');
                    for (int d = 0; d < row.Length; d++)
                    {
                        row[d] = row[d].Trim();
                        string[] num = row[d].Split(' ');
                        //string[] num = row[d].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                        for (int w = 0; w < num.Length; w++)
                        {
                            cub[w, h, d] = short.Parse(num[w]);
                            totalSum = totalSum + cub[w, h, d];
                        }
                    }
            }

            long currentSum = 0;
            int splitCounter = 0;
            for (int w = 0; w < width - 1; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        currentSum = currentSum + cub[w, h, d];
                    }
                }

                if (currentSum * 2 == totalSum)
                {
                    splitCounter++;
                }
            }

            currentSum = 0;
            for (int h = 0; h < height - 1; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        currentSum = currentSum + cub[w, h, d];
                    }
                }

                if (currentSum * 2 == totalSum)
                {
                    splitCounter++;
                }
            }

            currentSum = 0;
            for (int d = 0; d < depth - 1; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    for (int h = 0; h < height; h++)
                    {
                        currentSum = currentSum + cub[w, h, d];
                    }
                }

                if (currentSum * 2 == totalSum)
                {
                    splitCounter++;
                }
            }

            Console.WriteLine(splitCounter);
        }
    }

