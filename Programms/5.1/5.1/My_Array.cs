using System;

namespace _5._1
{
    public class My_Array
    {
        public int[] A { get; private set; }

        public My_Array(int[] v)
        {
            A = new int[v.Length];
            v.CopyTo(A, 0);
        }

        public My_Array(My_Array a) : this(a.A) { }

        public void Sum(int[] v)
        {
           if (A.Length!=v.Length)
                throw new ArgumentException("Lengths are not equal");
           if (A==null || v==null)
                throw new NullReferenceException("One of arrays is Null");
           else
                if (A.Length==0 || v.Length==0)
                    throw new NullReferenceException("One of arrays is Null");
            for (int i = 0; i < A.Length; i++)
                A[i] += v[i];
        }

        public double ScalarProduct(int[] v)
        {
            double scalar = 0;
            if (A.Length != v.Length)
                throw new ArgumentException("Lengths are not equal");
            if (A == null || v == null)
                throw new NullReferenceException("One of arrays is Null");
            else
                 if (A.Length == 0 || v.Length == 0)
                throw new NullReferenceException("One of arrays is Null");
            for (int i = 0; i < A.Length; i++)
                scalar+=A[i]*v[i];

            return scalar;
        }

        public int[] Concatenation(int[] v)
        {
            if (A == null || v == null)
                throw new NullReferenceException("One of arrays is Null");
            else
                 if (A.Length == 0 || v.Length == 0)
                throw new NullReferenceException("One of arrays is Null");

            int[] conc = new int[v.Length + A.Length];

            for (int i = 0; i < A.Length; i++)
                conc[i] = A[i];
            for (int i = 0; i < v.Length; i++)
                conc[i+A.Length] = v[i];
            return conc;
        }
    }
}
