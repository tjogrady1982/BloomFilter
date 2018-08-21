using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BloomFilter
{
    public class FileDownloader
    {
        public List<string> WordList = new List<string>();

        public FileDownloader()
        {
            Download();
        }
        public void Download()
        {
            var wc = new WebClient();
            var data = wc.OpenRead("http://codekata.com/data/wordlist.txt");

            var sr = new StreamReader(data);

            string currentLine;


            do
            {
                currentLine = sr.ReadLine();

                WordList.Add(currentLine);
            }

            while (currentLine != null);

            data.Close();
        }

    }
}
