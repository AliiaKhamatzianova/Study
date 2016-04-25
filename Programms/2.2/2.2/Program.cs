using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    /// <summary>
    /// Эта программа записывает в массив byte/char цифры числа
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите число");
            try
            {
                string a = Console.ReadLine();

                char[] array_char = new char[a.Length];
                byte[] array_byte = new byte [a.Length];

                int i = 0;
                foreach (char c in a)
                {
                    array_char[i] = c;
                    array_byte[i] = (byte)c;
                    i++;
                }

                for (i = 0; i < a.Length; i++)
                    Console.Write((char)array_byte[i] + " ");

                Console.WriteLine();

                for (i = 0; i < a.Length; i++)
                    Console.Write(array_char[i] + " ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
