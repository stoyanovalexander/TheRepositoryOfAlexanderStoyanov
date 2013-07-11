using System;
using System.Collections.Generic;
using System.Linq;

    class CoinsCalculation
    {
        static void Main()
        {
            int wontedSum = 33;
            int[] coinsItems = { 1, 2, 5 };
            int[] coins = new int[coinsItems.Length];
            Console.Write("N="+ wontedSum+"=>");
            GreedyChanges(wontedSum, coins, coinsItems);
            PrintGreedyResult(coinsItems, coins);
        }

        private static void GreedyChanges(int amount, int[] coin, int[] denomination)
        {
            int counter;
            Array.Sort(denomination, 1, denomination.Length - 1);
            for (int i = 0; i < coin.Length; i++)
            {
                coin[i] = 0;
            }
            for (counter = coin.Length - 1; counter >= 0 & amount > 0; counter--)
            {
                coin[counter] = amount / denomination[counter];
                amount -= coin[counter] * denomination[counter];
            }
        }

        private static void PrintGreedyResult(int[] coinsItems, int[] coins)
        {
            for (int i = 0; i < coins.Length-1; i++)
            {
                if (coins[i] > 0)
                {
                    Console.Write("{0} coins x {1} + ", coins[i], coinsItems[i]);
                }
            }

            if (coins[coins.Length-1] > 0)
            {
                Console.Write("{0} coins x {1}", coins[coins.Length-1], coinsItems[coins.Length-1]);
            }
            Console.WriteLine();
        }
    }
