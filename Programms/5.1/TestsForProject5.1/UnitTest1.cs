using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._1;

namespace TestsForProject5._1
{
    [TestClass]
    public class UnitTestArray
    {
        //SUM
        [TestMethod]
        public void TestSumArraySameLength()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            a.Sum(new int[] { 1, 2, 3 });
            CollectionAssert.AreEqual(a.A, new int[] { 2, 4, 6 });
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestSumNullArray()
        {
            My_Array a = null;
            a.Sum(new int[] { 1, 2, 3 });
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSumArrayDifLength()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            a.Sum(new int[] { 1, 2 });
            Assert.Fail();
        }

        //SCALAR PRODUCT
        [TestMethod]
        public void TestScalarProductArraySameLength()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            double scalar = a.ScalarProduct(new int[] { 1, 2, 3 });
            Assert.AreEqual(scalar,14);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestScalarProductNullArray()
        {
            My_Array a = null;
            double scalar = a.ScalarProduct(new int[] { 1, 2, 3 });
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScalarProductArrayDifLength()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            double scalar = a.ScalarProduct(new int[] { 1, 2 });
            Assert.Fail();
        }


        //CONCATENATION
        [TestMethod]
        public void TestConcatenationNotNullArray()
        {
            My_Array a = new My_Array(new int[] { 1, 2, 3 });
            int [] conc = a.Concatenation(new int[] { 3, 2, 1 });
            CollectionAssert.AreEqual(conc, new int[] { 1, 2, 3, 3,2,1 });
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestConcatenationNullArray()
        {
            My_Array a = null;
            int [] conc = a.Concatenation(new int[] { 1, 2, 3 });
            Assert.Fail();
        }
    }
}
