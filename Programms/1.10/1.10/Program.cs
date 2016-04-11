using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10
{
    /// <summary>
    /// Это программа выводит все делители натурального числа
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            try
            {
                int n = Int32.Parse(Console.ReadLine());

                Console.Write("Делители числа " + n + " : ");
                for (int i=1; i<=n/2;i++)
                {
                    if (n % i == 0)
                        Console.Write(i+" ");
                }
                        Console.Write(n+" ");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
