using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        /// <summary>
        /// Это программа для вывода последовательности из 1/-1 заданной пользователем длины 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                #region
                for (int i = 0; i < n; i++)
                {
                    Console.Write(((i % 2) == 1) ? "-1 " : "1 ");
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
