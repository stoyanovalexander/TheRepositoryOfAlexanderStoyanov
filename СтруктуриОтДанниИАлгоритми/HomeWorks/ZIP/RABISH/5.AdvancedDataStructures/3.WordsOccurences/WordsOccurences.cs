using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

    class WordsOccurances
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            TrieNode start = new TrieNode();
            var allWords = SetInputText();

            List<string> wordsToSearch = new List<string>();
            for (int i = 0; i < 50; i++)
            {
                wordsToSearch.Add(allWords[i].ToString());
            }

            AddWordsForSearchInTrie(start, wordsToSearch);

            IncrementOccuranceCountTrie( start, allWords);
       
            Console.WriteLine("The words count : ");
            foreach (var word in wordsToSearch)
            {
                Console.WriteLine("{0}: {1}", word, start.CountWords(start, word));
            }
        }

        private static void IncrementOccuranceCountTrie( TrieNode start, MatchCollection allWords)
        {
            foreach (var word in allWords)
            {
                start.AddOccuranceIfExists(start, word.ToString());
            }
        }

        private static void AddWordsForSearchInTrie(TrieNode start, List<string> words)
        {
            foreach (var item in words)
            {
                start.AddWord(start, item.ToString());
            }
        }

        static MatchCollection SetInputText()
        {
            string inputText;
            StreamReader streamReader = new StreamReader("someText.txt");
            using (streamReader)
            {
                inputText =streamReader.ReadToEnd().ToLower();
            }

            var matches = Regex.Matches(inputText, @"[a-zA-Z]+");
            return matches;
        }
    }
