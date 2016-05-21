using System;
using System.Linq;

namespace ConsoleApplication4
{
    class Program
    {
        static int DigitsSum (string digits)
        {
            
            int tmp = 0;
            foreach (char c in digits)
                tmp += c - '0';
            return tmp;
        }
        static int ChecksSum (int number)
        {
           
            char[] digits = number.ToString().ToArray();

            for (int i = 0; i < digits.Length; i++)
                Console.Write(2 * (digits[i] - '0') + " ");

            for (int i = digits.Length - 1; i >= 0; i -= 2)
            {
                string str = ((digits[i] - '0') * 2).ToString();

                digits[i] = (char)(DigitsSum(str) + '0');
            }
            int tmp1 = 0;
            foreach (char cc in digits)
                tmp1 += cc - '0';
            int result = 10 - tmp1 % 10;
            return result;
        }

        static int LinkCheckSum (int number)
        {
            var result =
            number.ToString()
                .Reverse()
                .Select(x => x - '0')
                .Zip(Enumerable.Range(0, 9), (x, y) => new { x, y })
                .Select(x => x.y % 2 == 0 ? x.x * 2 : x.x)
                .Select(x => x.ToString().Sum(y => y - '0'))
                .Reverse()
                .Sum();
            return 10-result%10;
        }

        static void Main(string[] args)
        {
            
            
        }
    }
}
