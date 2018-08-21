using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    public class SimpleWordSearch
    {
        public bool FindWord(string word, List<string> words)
        {
            foreach (var item in words)
            {
                if (item == word)
                {

                    return true;
                }
            }
            return false;
        }
    }
}
