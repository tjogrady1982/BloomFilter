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

                //bloomFilter.SetValueInBloomFilter(word);

            }
        }
    }
}
