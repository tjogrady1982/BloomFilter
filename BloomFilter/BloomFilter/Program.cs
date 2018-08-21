using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().RunBloomFilter();
        }
        private void RunBloomFilter()
        {
            var wordList = new FileDownloader();
            var bloomFilter = new BloomFilter();

            foreach (var word in wordList.WordList)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    bloomFilter.AddData(word);
                }
            }
            //bloomFilter.LookUp("ball"); //should return true
            //bloomFilter.LookUp("a6a7shga"); //should return false
            var randomList = new RandomFiveLetterGenerator();
            var ra = randomList.randomFiveCharacterList(10000);
            int i = 0;

            foreach (var word in ra)
            {
              if  (bloomFilter.LookUp(word) == true)//random string found in lookup
                {
                    var search = new SimpleWordSearch();
                    var boolSearch = search.FindWord(word, wordList.WordList);

                    if(boolSearch == false)
                    {
                        Console.WriteLine($"The Word {word} is a false positive");
                        i++;
                    }
                }
            }
            Console.WriteLine($"There are {i} false positives");
            Console.ReadLine();
        }
    }
}
