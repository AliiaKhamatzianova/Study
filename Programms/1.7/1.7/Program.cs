using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7
{
    /// <summary>
    /// Это программа проверяет введенное чило на простоту
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            try
            {
                #region
                int n = Int32.Parse(Console.ReadLine());
                bool b = true;

                #region
                for (int i=2; i<= Math.Sqrt(n);i++)
                {
                    if (n % i == 0)
                        b = false;
                        
                }
                #endregion

                if (b==false)
                    Console.WriteLine("Число " + n + " не является простым");
                else
                    Console.WriteLine("Число " + n + " является простым");

                #endregion

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
