using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    public class BloomFilter
    {
        const int arraySize = 1000000;
        const int numberOfHashes = 5; //allows multiple hash values but these are not truely independent
        BitArray bloom = new BitArray(arraySize);

        private int[] Hashes(string word, int numberOfHashes)
        {
            int[] hashes = new int[numberOfHashes];
            hashes[0] = Math.Abs(word.GetHashCode());
            Random R = new Random(hashes[0]);
            for (int i = 1; i < numberOfHashes; i++)
            {
                hashes[i] = R.Next();
            }
            return hashes;
        }
        public void AddData(string word)
        {
            int[] hashes = Hashes(word, numberOfHashes);
            for (int i = 0; i < numberOfHashes; i++)
            {
                bloom.Set(hashes[i] % arraySize, true);
            }
        }

    }
}
