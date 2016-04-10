using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    /// <summary>
    /// Эта программа определяет НОД двух целлых чисел
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите первое число");
            try
            {
                int a = Int32.Parse(Console.ReadLine());
                int a1 = a;
                Console.WriteLine("Ввведите второе число");
                int b = Int32.Parse(Console.ReadLine());
                int b1 = b;

                while (b!=0)
                {
                    int tmp = a % b;
                    a = b;
                    b = tmp;
                }

                Console.WriteLine(string.Format("НОД({0},{1})",a1,b1)+ " "+ "="+ " "+ a);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
