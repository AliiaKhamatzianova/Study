using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8
{
    /// <summary>
    /// Это программа для подсчета суммы 1 в двоичном представлении числа
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
                int s;
                if (n != 0)
                {
                    s = 1;
                    #region
                    while (n != 1)
                    {
                        s += n % 2;
                        n /= 2;
                    }
                    #endregion
                }
                else
                    s = 0;

                Console.WriteLine("Сумма 1 двоичного предстваления числа = " + s);
                #endregion
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
