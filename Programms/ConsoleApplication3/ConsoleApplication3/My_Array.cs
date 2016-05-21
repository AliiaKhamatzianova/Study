using System;
using System.Collections;

namespace ConsoleApplication3
{
    public class My_Array
    {
        //private My_Array a;

        public int[] A { get; private set; }

        public My_Array(int[] v)
        {
            A =new int[v.Length];
            v.CopyTo(A,0);
        }

        public My_Array(My_Array a):this(a.A){ }
        

        public void Sum(int[] v)
        {
            if (A.Length != v.Length)
                throw new ArgumentException("Lengths are not equal");
            for (int i = 0; i < A.Length; i++)
                A[i] += v[i];
        }
    }
}