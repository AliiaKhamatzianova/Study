using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._1
{
    class Program
    {
        /// <summary>
        /// Метод построчно считывает входной поток и построчно записывает в выходной поток слова в обратном порядке
        /// </summary>
        /// <param name="input"></param>
        public static void PrintReverse(StreamReader input)
        {
            
            var output_file = new FileInfo("output.txt");
            if (output_file.Exists)
            {
                output_file.Delete();
            }
            var output = new StreamWriter("output.txt", true);
            using (output)
            {
                using (input)
                {

                    while (!input.EndOfStream)
                    {
                        string result = "";
                        string tmp_out = "";
                        string tmp = input.ReadLine();

                        foreach (char c in tmp)
                        {

                            if (c != ' ' && c != '!' && c != '.' && c != '?' && c!=',')
                            {
                                tmp_out += c;
                            }
                            else
                            {
                                    char[] tmp1 = tmp_out.Reverse().ToArray();
                                    foreach (char c1 in tmp1)
                                        result += c1;
                                    result += c;
                                    tmp_out = "";
                            }
                           
                        }

                            output.WriteLine(result);


                    }


                }
            }
        }
        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            
            PrintReverse(input);
        }
    }
}
