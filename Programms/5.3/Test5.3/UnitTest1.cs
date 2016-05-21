using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._3;

namespace Test5._3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTransporateMatrix_NotNull()
        {
            Matrix m; 
            int[][] mint=new int[4][];
            int tmp = 1;
            for (int i = 0; i < 4; i++)
            {
                mint[i] = new int[3];
                for (int j=0; j<3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[][] v = m.Transporate();
            
            int[][] mint3 = new int[3][];
            tmp = 1;
            int tmp2 = 1;
            for (int i = 0; i < 3; i++)
            {
                mint3[i] = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    mint3[i][j] = tmp;
                    tmp += 3;
                }
                tmp2++;
                tmp = tmp2;
            }
            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(v[i], mint3[i]);
            }
            
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestTransporateMatrix_Null()
        {
            Matrix m; 
            int[][] mint=new int[4][];
            int tmp = 1;
            for (int i = 0; i < 0; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);
            m = null;
            int[][] v = m.Transporate();

            CollectionAssert.AreEqual(v, mint);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMultiplicationOnScalar_NotNull()
        {
            Matrix m; 
            int[][] mint = new int[4][];
            int tmp = 1;
            for (int i = 0; i < 4; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[][] v = m.MultiplicationOnScalar(2);

            int[][] mint3 = new int[4][];

            for (int i = 0; i < 4; i++)
            {
                mint3[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    mint3[i][j] = 2*mint[i][j];

                }

            }
            for (int i = 0; i < 4; i++)
            {
                CollectionAssert.AreEqual(v[i], mint3[i]);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMultiplicationOnScalar_Null()
        {
            Matrix m;
            int[][] mint = new int[4][];
            int tmp = 1;
            for (int i = 0; i < 0; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);
            m = null;
            int[][] v = m.MultiplicationOnScalar(2);

            int[][] mint3 = new int[4][];

            for (int i = 0; i < 4; i++)
            {
                mint3[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    mint3[i][j] = 2 * mint[i][j];

                }

            }

           // CollectionAssert.AreEqual(v, mint);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMultiplicationArrayOnMatrix_NotNull()
        {
            Matrix m;
            int[][] mint = new int[3][];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                mint[i] = new int[4];
                for (int j = 0; j < 4; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[] array = new int [] {1,1,1 };
            int[] v = m.MultiplicationArrayOnMatrix(array);

            int[] mint3 = new int[4];
            mint3[0] = 15;
            mint3[1] = 18;
            mint3[2] = 21;
            mint3[3] = 24;

                CollectionAssert.AreEqual(v, mint3);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMultiplicationArrayOnMatrix_Null()
        {
            Matrix m;
            int[][] mint = new int[3][];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[] array = new int[] { 1, 1, 1 };
            m = null;
            int[] v = m.MultiplicationArrayOnMatrix(array);

            int[] mint3 = new int[3];
            mint3[0] = 12;
            mint3[1] = 15;
            mint3[2] = 18;

            CollectionAssert.AreEqual(v, mint3);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMultiplicationArrayOnMatrix_DifferentLengths()
        {
            Matrix m;
            int[][] mint = new int[3][];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[] array = new int[] { 1, 1, 1 ,1};
           
            int[] v = m.MultiplicationArrayOnMatrix(array);

            int[] mint3 = new int[0];
            mint3[0] = 12;
            mint3[1] = 15;
            mint3[2] = 18;
            

            CollectionAssert.AreEqual(v, mint3);
            Assert.Fail();
        }

        [TestMethod]
        public void TestMultiplicationMatrixOnArray_NotNull()
        {
            Matrix m;
            int[][] mint = new int[4][];
            int tmp = 1;
            for (int i = 0; i < 4; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[] array = new int[] { 1, 1, 1 };
            int[] v = m.MultiplicationMatrixOnArray(array);

            int[] mint3 = new int[4];
            mint3[0] = 6;
            mint3[1] = 15;
            mint3[2] = 24;
            mint3[3] = 33;

            CollectionAssert.AreEqual(v, mint3);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMultiplicationMatrixOnArray_Null()
        {
            Matrix m;
            int[][] mint = new int[3][];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[] array = new int[] { 1, 1, 1 };
            m = null;
            int[] v = m.MultiplicationMatrixOnArray(array);

            int[] mint3 = new int[3];
            mint3[0] = 12;
            mint3[1] = 15;
            mint3[2] = 18;

            CollectionAssert.AreEqual(v, mint3);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMultiplicationMatrixOnArray_DifferentLengths()
        {
            Matrix m;
            int[][] mint = new int[3][];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[] array = new int[] { 1, 1, 1, 1 };

            int[] v = m.MultiplicationMatrixOnArray(array);

            int[] mint3 = new int[0];
            mint3[0] = 12;
            mint3[1] = 15;
            mint3[2] = 18;


            CollectionAssert.AreEqual(v, mint3);
            Assert.Fail();
        }

        [TestMethod]
        public void TestGetSubMatrix_NotNullValidRange()
        {
            Matrix m;
            int[][] mint = new int[3][];
            int tmp = 1;
            for (int i = 0; i < 3; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[][] v = m.GetSubMatrix(1,1,2,2);

            int[][] mint3 = new int[2][];
            for (int i = 0; i < mint3.Length; i++)
                mint3[i] = new int[2];

            mint3[0][0] = 5;
            mint3[0][1] = 6;
            mint3[1][0] = 8;
            mint3[1][1] = 9;

            for (int i = 0; i < 2; i++)
            {
                CollectionAssert.AreEqual(v[i], mint3[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetSubMatrix_InvalidRange()
        {
            Matrix m;
            int[][] mint = new int[4][];
            int tmp = 1;
            for (int i = 0; i < 4; i++)
            {
                mint[i] = new int[3];
                for (int j = 0; j < 3; j++)
                    mint[i][j] = tmp++;

            }
            m = new Matrix(mint);

            int[][] v = m.GetSubMatrix(1, 2, 2, 1);

            int[][] mint3 = new int[2][];
            for (int i = 0; i < mint3.Length; i++)
                mint3[i] = new int[2];

            mint3[0][0] = 5;
            mint3[0][1] = 6;
            mint3[1][0] = 8;
            mint3[1][1] = 9;

            for (int i = 0; i < 2; i++)
            {
                CollectionAssert.AreEqual(v[i], mint3[i]);
            }
            Assert.Fail();
        }
    }
}
