using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    /// <summary>
    /// Эта программа содержит метод нахождения НОК элементов массива
    /// </summary>
    class Program
    {
        static int GCD(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                while (b != 0)
                {
                    int tmp = a % b;
                    a = b;
                    b = tmp;
                }
                return Math.Abs(a);
            }
            else
                if ((a != 0 && b == 0) || (a == 0 && b != 0))
                return 1;
            else
                throw new Exception("Наибольший общий делитель существует и однозначно определён, если хотя бы одно из чисел не равно нулю!");

        }

        static int LCM(int a, int b)
        {
            return Math.Abs((a * b) / GCD(a, b));
        }

        static int[] Get_array_from_string (string string_array)
        {
            int n = 0;

            if (string_array.Contains("  "))
                throw new Exception("Веедены не корректные символы!");
            if (string_array.Last() == ' ')
                string_array = string_array.Remove(string_array.Length - 1, 1);
            if (string_array.First() == ' ')
                string_array = string_array.Remove(0, 1);


            foreach (char c in string_array)
            {
                
                if (c == ' ')
                    n++;
                else
                    if ((c < '0' || c > '9') && c != '-')
                    throw new Exception("Веедены не корректные символы!");
            }

            int[] array = new int[n + 1];
            int i = 0;
            string tmp = "";

            foreach (char c in string_array)
            {
                if (c != ' ')
                {
                    tmp += c;
                }
                else
                {
                    array[i] = Int32.Parse(tmp);
                    tmp = "";
                    i++;
                }
            }
          //  if (i==n)
                array[i] = Int32.Parse(tmp);

            return array;
        }


        static void Print_array (int [] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]+" ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите элементы массива через пробел");

            try
            {
                string string_array = Console.ReadLine();
                int [] array =Get_array_from_string(string_array);
                int lcm=LCM(array[0],array[1]);
                for (int i =2; i< array.Length; i++)
                {
                    lcm = LCM(lcm, array[i]);
                }
                Print_array(array);

                Console.WriteLine("LCM = "+lcm);
               
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
