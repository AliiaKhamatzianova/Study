using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    /// <summary>
    /// Поиск минимума и максимума за один проход
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {45,3,112,78,0,1213 };
            int min = array[0];
            int max = array[0];

            for (int i=0; i< array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                else
                    if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine("Min = " + min);
           Console.WriteLine("Max = " + max);
        }
    }
}
