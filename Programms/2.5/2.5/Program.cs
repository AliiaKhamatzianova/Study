using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    /// <summary>
    /// Это программа записывает двоичное представление числа в массив
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            string n_binary = "";

            if (n >= 1)
            {
                while (n != 1)
                {
                    n_binary += n % 2;
                    n /= 2;
                }
                n_binary += "1";


                char[] binary_n = new char[n_binary.Length];
                binary_n = n_binary.Reverse().ToArray();

                for (int i = 0; i < binary_n.Length; i++)
                {
                    Console.Write(binary_n[i] + " ");
                }

                Console.WriteLine();
            }
            else
                if (n != 0)
                Console.WriteLine("Введено некорректное число");
            else
                Console.WriteLine(0);
        }
    }
}
