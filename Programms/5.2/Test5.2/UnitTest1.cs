using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._2;

namespace Test5._2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GCD_108_48()
        {
            int v = Arithmetic.GCD(108, 48);
            Assert.AreEqual(v, 12);
        }

        [TestMethod]
        public void Test_GCD_Minus108_48()
        {
            int v = Arithmetic.GCD(-108, 48);
            Assert.AreEqual(v, 12);
        }

        [TestMethod]
        public void Test_GCD_48_0()
        {
            int v = Arithmetic.GCD(48, 0);
            Assert.AreEqual(v, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_GCD_0_0()
        {
            int v = Arithmetic.GCD(0, 0);
            Assert.AreEqual(v, 1);
            Assert.Fail();
        }

        [TestMethod]
        public void Test_LCM_108_48()
        {
            int v = Arithmetic.LCM(108, 48);
            Assert.AreEqual(v, 432);
        }

        [TestMethod]
        public void Test_LCM_Minus108_48()
        {
            int v = Arithmetic.LCM(-108, 48);
            Assert.AreEqual(v, 432);
        }

        [TestMethod]
        public void Test_LCM_48_0()
        {
            int v = Arithmetic.LCM(48, 0);
            Assert.AreEqual(v, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_LCM_0_0()
        {
            int v = Arithmetic.LCM(0, 0);
            Assert.AreEqual(v, 0);
            Assert.Fail();
        }

        [TestMethod]
        public void Test_GCD_Array_3_9_12()
        {
            int v = Arithmetic.GCD_Array(new int[] { 3, 9, 12 });
            Assert.AreEqual(v, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_GCD_Array_0()
        {
            int v = Arithmetic.GCD_Array(new int [0]);
            Assert.AreEqual(v, 0);
            Assert.Fail();
        }

        [TestMethod]
        public void Test_LCM_Array_3_9_12()
        {
            int v = Arithmetic.LCM_Array(new int[] { 3, 9, 12 });
            Assert.AreEqual(v, 36);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_LCM_Array_0()
        {
            int v = Arithmetic.LCM_Array(new int[0]);
            Assert.AreEqual(v, 0);
            Assert.Fail();
        }

        [TestMethod]
        public void Test_Pow_2_3()
        {
            int v = Arithmetic.Pow(2,3);
            Assert.AreEqual(v,8);
        }

        [TestMethod]
        public void Test_Pow_Minus2_3()
        {
            int v = Arithmetic.Pow(-2, 3);
            Assert.AreEqual(v, -8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Pow_2_Minus3()
        {
            int v = Arithmetic.Pow(2, -3);
            Assert.AreEqual(v, 1);
            Assert.Fail();
        }
    }
}
