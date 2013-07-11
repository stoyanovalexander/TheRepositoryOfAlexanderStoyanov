using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
using System.Diagnostics;

    class ElementsInRange
    {
        static void Main()
        {
            StringBuilder allProductsToString = new StringBuilder();
            Stopwatch stopWatch = new Stopwatch();
            OrderedBag<Product> siabongaOrderedBag = new OrderedBag<Product>();
            int ranges = 10000;

            //stopWatch.Start();
            AddProductsToBag(siabongaOrderedBag, 500001);

            List<Product> twentyProductsInSomeRange=FindFirstTwenty(siabongaOrderedBag,55,452);
            for (int i = 0; i<twentyProductsInSomeRange.Count; i++)
            {
                Console.WriteLine("Name: "+twentyProductsInSomeRange[i].Name+"  Price: "+twentyProductsInSomeRange[i].Price);
            }

                stopWatch.Start();
            for (int i = 0; i < ranges; i++)
            {
                //stopWatch.Start();
                List<Product> found = FindFirstTwenty(siabongaOrderedBag, 100000, 100000 + i);

                //time for adding to stringbuilder not included
                //stopWatch.Stop();
                allProductsToString.Append(found.GetProductsToString());
            }

            // uncomment to see all ranges found
            // Console.WriteLine(allProductsToString.ToString());
            Console.WriteLine("Range searching of first 20 elm. in 500 000 elm. 10 000 times done for:\n                            "
                                + stopWatch.Elapsed);
        }

        public static void AddProductsToBag(OrderedBag<Product> orderedBag, int biggestPrice)
        {
            Random someRandom = new Random();
            for (int i = 1; i < biggestPrice; i++)
            {
                orderedBag.Add(new Product(i+".SiabongaProduct", someRandom.Next(1,biggestPrice)));
            }
        }

        public static List<Product> FindFirstTwenty(OrderedBag<Product> orderedBag, int lowPrice, int highPrice)
        {
            var result = orderedBag.Range(new Product("searchItem", highPrice), true,
                new Product("searchItem", lowPrice), true);

            List<Product> listResult = new List<Product>();

            if (result.Count == 0)
            {
                return listResult;
            }

            for (int i = 0; i < 20 && i < result.Count; i++)
            {
                listResult.Add(result[i]);
            }

            return listResult;
        }



    }
