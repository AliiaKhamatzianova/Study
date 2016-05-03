using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace _4._6
{
    class Program
    {
        public static Hashtable ReadWords(StreamReader input)
        {
            Hashtable words = new Hashtable();
            using (input)
            {
                while (!input.EndOfStream)
                {
                    var sr = input.ReadLine().Split(" ,.!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (string c in sr)
                        if (words.ContainsKey(c))
                            words[c] = (int)words[c]+1;
                        else
                            words.Add(c, 1);
                }

            }
            return words;
        }

        public static void PrintWords(Hashtable words)
        {
            var output_file = new FileInfo("output.txt");
            if (output_file.Exists)
            {
                output_file.Delete();
            }
            var output = new StreamWriter("output.txt", true);
            using (output)
            {
                foreach (DictionaryEntry kvp in words)
                {
                    output.WriteLine((string)kvp.Key + " " + (int)kvp.Value);
                }
            }
        }
        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            PrintWords(ReadWords(input));
        }
    }
}
