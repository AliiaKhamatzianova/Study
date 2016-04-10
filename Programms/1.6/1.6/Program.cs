using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    /// <summary>
    /// Это программа вычисляет НОК двух целых чисел
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            try
            {
                #region
                int a = Int32.Parse(Console.ReadLine());
                int a1 = a;
                Console.WriteLine("Введите второе число");
                int b = Int32.Parse(Console.ReadLine());
                int b1 = b;

                #region
                while (b!=0)
                {
                    int tmp = a % b;
                    a = b;
                    b = tmp;
                }
                #endregion

                Console.WriteLine(string.Format("НОК({0},{1})",a1,b1) + " = " + a1*b1/a);
                #endregion
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
