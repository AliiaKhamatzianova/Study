using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9
{
    /// <summary>
    /// Эта программа для возведения вещественного числа в целую степень
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число, которое необходимо возвести в степень");

            try
            {
                #region
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите степень, в котороую нужно возвести число");
                int n = Int32.Parse(Console.ReadLine());
                double r=1;

                for (int i=0; i< n; i++)
                {
                    r*= a;
                }

                Console.WriteLine("Результат возведения числа в степень" + " " + r);
                #endregion
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
