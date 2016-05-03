using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._5
{
    class Program
    {
        public static Dictionary<char,int> ReadCharacters(StreamReader input)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            using (input)
            {
                while (!input.EndOfStream)
                {
                    var sr = input.ReadLine();
                    foreach (char c in sr)
                        if (characters.ContainsKey(c))
                            characters[c]++;
                        else
                            characters.Add(c, 1);

                }
               
            }
            return characters;
        }

        public static void PrintWords (Dictionary<char,int> characters)
        {
            var output_file = new FileInfo("output.txt");
            if (output_file.Exists)
            {
                output_file.Delete();
            }
            var output = new StreamWriter("output.txt", true);
            using (output)
            {
                foreach (KeyValuePair<char,int> kvp in characters)
                {
                    output.WriteLine(kvp.Key+" "+kvp.Value);
                }
            }
        }

        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            PrintWords(ReadCharacters(input));
        }
    }
}
