using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7
{
    /// <summary>
    /// Подсчет контрольной суммы числа
    /// </summary>
    class Program
    {

        static int Step1 (int x)
        {
            string string_x = x.ToString();
            string tmp = "";
            for (int i = 0; i < string_x.Length; i++)
            {
                int s = 0;
                if (i % 2 == 0)
                    s = Int32.Parse(string_x[i].ToString()) * 2;
                else
                    s = Int32.Parse(string_x[i].ToString());
                if (s > 10)
                    tmp += s / 10 + s % 10;
                else
                    tmp += s;
            }
            int result = Int32.Parse(tmp);
            return result;
        }

        static int Step2 (int x)
        {
            string string_x = x.ToString();
            int s = 0;
            for (int i = 0; i < string_x.Length; i++)
                s += Int32.Parse(string_x[i].ToString());

            return s;
        }

        static int CheckSum(int x)
        {
            return (10- Step2(Step1(x))%10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(1%10);
            // Console.WriteLine(Step1(876));
            //Console.WriteLine(Step2(Step1(876)));
            Console.WriteLine(CheckSum(515));
        }
    }
}
