using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _4._7
{
    class Program
    {
        public static int[] ReadNumerics (StreamReader input)
        {
            using (input)
            {
                var sr = input.ReadLine().Split(' ').ToArray();
                int[] numerics = new int[sr.Length];
                for (int i = 0; i < sr.Length; i++)
                    numerics[i] = Int32.Parse(sr[i]);
                return numerics;
            }
            
        }

        public static bool IsSaw (int []numerics)
        {
            bool flag = false;

            int previous = numerics[0];
            int next = numerics[1];

            for (int i=1; i < numerics.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (previous < numerics[i])
                    {
                        flag = true;
                        previous = numerics[i];
                    }
                    else
                        return false;
                }
                else
                {
                    if (previous > numerics[i])
                    {
                        flag = true;
                        previous = numerics[i];
                    }
                    else
                        return false;
                }
            }

            return flag;
        }

        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            Console.WriteLine(IsSaw(ReadNumerics(input)));
        }
    }
}
