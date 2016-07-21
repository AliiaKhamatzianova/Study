using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sortings;

namespace UnitTestSortings
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQuickSort()
        {
            int[] array = new int[] {5,1,6,9,8,7,4,2,3,0 };
            Sorting.QuickSort(array,0, array.Length-1);
            CollectionAssert.AreEqual(array,new int[] {0,1,2,3,4,5,6,7,8,9});
        }
    }
}
