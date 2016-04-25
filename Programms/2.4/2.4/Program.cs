using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    /// <summary>
    /// Эта программа складывает два числа, заданных в виде массива цифр
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            try
            {
                string a = Console.ReadLine();
                int a_int = Int32.Parse(a);
                Console.WriteLine("Введите второе число");
                string b = Console.ReadLine();
                int b_int = Int32.Parse(b);

                int[] array_a = new int[a.Length];
                int [] array_b = new int[b.Length];

                int i = a.Length-1;
                while(a_int%10!=0)
                {
                    array_a[i] = a_int % 10;
                    a_int /= 10;
                    i--;
                }

                i = b.Length-1;
                while (b_int % 10 != 0)
                {
                    array_b[i] = b_int % 10;
                    b_int /= 10;
                    i--;
                }

                int max_length = (array_a.Length > array_b.Length) ? array_a.Length : array_b.Length;
                int min_length = (array_a.Length < array_b.Length) ? array_a.Length : array_b.Length;

                int tmp = 0;
                int[] array_s = new int[max_length+1];

                #region
                for (i = min_length-1; i >= 0; i-- )
                {
                    int s = array_b[i] + array_a[i];
                    if (s >= 10)
                    {
                        if (tmp == 0)
                        {
                            array_s[i] = s % 10;
                            tmp = s / 10;
                        }
                        else
                        {
                            array_s[i] = s % 10 + tmp;
                            tmp = s / 10;
                        }
                    }
                    else
                    {
                        if (tmp == 0)
                        {
                            array_s[i] = s;
                        }
                        else
                        {
                            array_s[i] = s + tmp;
                            tmp = 0;
                        }
                    }
                }
                #endregion

                #region
                for (i = max_length-1; i > min_length - 1; i--)
                {
                    if (tmp == 0)
                    {
                        if (max_length == array_a.Length)
                            array_s[i] = array_a[i];
                        else
                            array_s[i] = array_b[i];
                    }
                    else
                    {
                        if (max_length == array_a.Length)
                        {
                            array_s[i] = array_a[i] + tmp;
                            tmp = 0;
                        }
                        else
                        {
                            array_s[i] = array_b[i]+tmp;
                            tmp = 0;
                        }

                    }
                }
                #endregion

                if ((array_b.Length == array_a.Length) && (tmp != 0))
                    array_s[max_length] = tmp;

                //if ((arra_))

                for (i=0; i<array_s.Length;i++)
                {
                    Console.Write(array_s[i]);
                }
                Console.WriteLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
