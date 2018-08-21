using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    public class RandomFiveLetterGenerator
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        char[] stringChars = new char[5];
        string randomFive;
        List<string> randomFiveList = new List<string>();

        public List<string> randomFiveCharacterList(int numberOfWords)
        {
            var random = new Random();
            for (int i = 0; i < numberOfWords; i++)
            {
               
                for (int j = 0; j < stringChars.Length; j++)
                {

                    stringChars[j] = chars[random.Next(chars.Length)];
                }

                randomFive = new String(stringChars);
                randomFiveList.Add(randomFive);
            }
            return randomFiveList;
        }


    }
}
