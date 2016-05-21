using System;

namespace _5._2
{
    static public class Arithmetic
    {
        public static int GCD(int a, int b)
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
                throw new ArgumentException("Наибольший общий делитель существует и однозначно определён, если хотя бы одно из чисел не равно нулю!");
        }

        public static int LCM(int a, int b)
        {
            return Math.Abs((a * b) / GCD(a, b));
        }

        public static int GCD_Array(int[] array)
        {
            if (array == null)
                throw new NullReferenceException("Array is Null");
            else
                if (array.Length == 0)
                throw new NullReferenceException("Array is Null");
            int gcd = GCD(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                gcd = GCD(gcd, array[i]);
            }
            return gcd;
        }

        public static int LCM_Array(int[] array)
        {
            if (array == null)
                throw new NullReferenceException("Array is Null");
            else
                if (array.Length == 0)
                throw new NullReferenceException("Array is Null");
            int lcm = LCM(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                lcm = LCM(lcm, array[i]);
            }
            return lcm;
        }

        //v1^v2
        public static int Pow(int v1, int v2)
        {
            if (v2 < 0)
                throw new ArgumentException("Pow is not int!");
            int y = 1;
            while (v2>0)
            {
                if (v2 % 2 !=0)
                    y *= v1;
                v2/= 2;
                v1 *= v1;
            }
            return y;
        }
    }
}