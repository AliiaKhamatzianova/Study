using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n =Int32.Parse(Console.ReadLine());

            #region
            while (n%10!=0)
            {
                Console.Write(n%10+" ");
                n /= 10;
            }
            #endregion
        }
    }
}
