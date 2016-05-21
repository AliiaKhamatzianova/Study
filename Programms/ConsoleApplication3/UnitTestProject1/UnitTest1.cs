using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GCD_108_48()
        {
            int v = Arithmetic.GCD(108,48);
            Assert.AreEqual(v,12);
        }
    }
    [TestClass]
    public class UnitTestArray
    {
        [TestMethod]
        public void Array_Create_FullCopy()
        {
            My_Array array=null;
            {
                int [] k = { 1, 2, 3 };
                array = new My_Array(k);

                k[0] = 2;
            }

            CollectionAssert.AreEqual(array.A, new int[] { 1,2,3});
        }
        [TestMethod]
        public void MyArrayToAnother()
        {
            My_Array a = new My_Array(new int[] { 1,2,3});
            My_Array b = new My_Array(a);

            CollectionAssert.AreEqual(a.A,b.A);
        }

        [TestMethod]
        public void CreateFromAnotherArray_FullCopy()
        {
            int[] x = new int[] { 1,2,3};
            My_Array a = new My_Array(x);
            My_Array b = new My_Array(a);
            a.Sum(x);
            CollectionAssert.AreEqual(a.A, x);
            Assert.Fail();
        }

        [TestMethod]
        public void Array_Sum_123_123_246()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            a.Sum(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(a.A, new int[] { 2, 4, 6 });
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void Array_Sum_ShorterLength()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            a.Sum(new int[] { 1,2});

            Assert.Fail();


        }

    }

    

}
