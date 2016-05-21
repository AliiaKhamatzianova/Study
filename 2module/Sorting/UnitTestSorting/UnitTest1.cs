using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sortings;

namespace UnitTestSorting
{
    [TestClass]
    public class UnitTestSorting
    {
        [TestMethod]
        public void TestSelectionSort()
        {
            int[] array = new int[] { 8,1,7,4,0,5,6,9,3,2};
            Sorting.SelectionSort(array);
            CollectionAssert.AreEqual(array, new int[] { 0,1,2,3,4,5,6,7,8,9});
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            int[] array = new int[] { 5, 2, 7, 3, 1, 9, 6, 0, 1, 4 };
            Sorting.InsertionSort(array);
            CollectionAssert.AreEqual(array, new int[] { 0, 1, 1, 2, 3, 4, 5, 6, 7, 9 });
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            int[] array = new int[] { 8, 1, 7, 4, 0, 5, 6, 9, 3, 2 };
            Sorting.BubbleSort(array);
            CollectionAssert.AreEqual(array, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        [TestMethod]
        public void TestShellSort()
        {
            int[] array = new int[] { 8, 1, 7, 4, 0, 5, 6, 9, 3, 2 };
            Sorting.ShellSort(array);
            CollectionAssert.AreEqual(array, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }
    }
}
