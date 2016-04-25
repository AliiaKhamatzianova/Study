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

        static int GCD(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                while (b != 0)
                {
                    int tmp = a % b;
                    a = b;
                    b = tmp;
                }
                return Math.Abs(a);
            }
            else
                if ((a != 0 && b == 0) || (a == 0 && b != 0))
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
