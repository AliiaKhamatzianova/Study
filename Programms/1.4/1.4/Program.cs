using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    /// <summary>
    /// Эта программа определяет является ли введенное число палиндромом
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите число");

            try
            {
                int n = Int32.Parse(Console.ReadLine());
                
                int b = 0;
                int tmp = n;
                #region
                while (tmp % 10 != 0)
                {
                    b *= 10;
                    b += tmp % 10;
                    tmp /= 10;
                }
                #endregion

                Console.WriteLine(((n == b) ? "Введенное число - палиндром" : "Введенное число - не палиндром"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
