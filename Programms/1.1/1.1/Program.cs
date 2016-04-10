using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");
            int n=Int32.Parse(Console.ReadLine());
            #region
            for (int i=0; i < n; i++)
            {
                Console.Write( ((i%2)==1)?"-1 ":"1 " );
            }
            #endregion
        }
    }
}
