using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    /// <summary>
    /// Это программа подсчитывает сумму цифр числа, заданного в массиве
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            try
            {
                string a = Console.ReadLine();
                int a_int = Int32.Parse(a);
                int n = a.Length;
                int[] array = new int[n];

                int i = 0;
                while (a_int%10!=0)
                {
                    array[i] = a_int % 10;
                    a_int /= 10;
                    i++;
                }

                int s = 0;

                for (i = 0; i < array.Length; i++)
                    s += array[i];

                Console.WriteLine("Сумма цифр числа равна" + " " + s);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
