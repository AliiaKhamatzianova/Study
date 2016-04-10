using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    /// <summary>
    /// Это программа выводит цифры введенного числа в обратном порядке
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            try
            {
                int n = Int32.Parse(Console.ReadLine());

                #region
                while (n % 10 != 0)
                {
                    Console.Write(n % 10 + " ");
                    n /= 10;
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
