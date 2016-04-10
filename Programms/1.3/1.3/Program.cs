using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    /// <summary>
    /// Это программа для подсчета суммы цифр введенного числа
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, сумму цифр которого надо посчитать");
            try
            {
                int n = Int32.Parse(Console.ReadLine());

                int s = 0;

                #region
                while (n % 10 != 0)
                {
                    s += n % 10;
                    n /= 10;
                }
                #endregion

                Console.WriteLine("Сумма цифр введенного числа = " + s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
