using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    /// <summary>
    /// Это программа содержит метод нахождения НОК двух целых чисел
    /// </summary>
    class Program
    {

        static int GCD(int x, int y)
        {
            if (x != 0 && y != 0)
            {
                while (y != 0)
                {
                    int tmp = x % y;
                    x = y;
                    y = tmp;
                }
                return Math.Abs(x);
            }
            else
                if ((x != 0 && y == 0) || (x == 0 && y != 0))
                return 1;
            else
                throw new Exception("Наибольший общий делитель существует и однозначно определён, если хотя бы одно из чисел не равно нулю!");

        }

        static int LCM (int a, int b)
        {
            return Math.Abs((a*b)/GCD(a,b));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите первое число");

            try
            {
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ввведите второе число");
                int b = Int32.Parse(Console.ReadLine());

                Console.WriteLine(string.Format("НОК({0},{1})", a, b) + " " + "=" + " " + LCM(a, b));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
