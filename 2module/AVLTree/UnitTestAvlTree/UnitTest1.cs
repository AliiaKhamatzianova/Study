using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AVLTree;

namespace UnitTestAvlTree
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFindExistElement()
        {
            AVLTree<int> avletree = new AVLTree<int>(Comparer<int>.Default);

            avletree.Add(1);
            avletree.Add(2);
            avletree.Add(3);

            avletree.Add(4);
            avletree.Add(5);
            avletree.Add(4);
            avletree.Add(3);

            avletree.Delete(3);
            avletree.Add(1);
            avletree.Add(6);
            avletree.Add(5);
            avletree.Add(2);


            bool exist = avletree.Search(3);
            Assert.AreEqual(true, exist);
            
        }

        [TestMethod]
        public void TestFindNotExistElement()
        {
            AVLTree<int> avletree = new AVLTree<int>(Comparer<int>.Default);

            avletree.Add(1);
            avletree.Add(2);
            avletree.Add(3);
            avletree.Add(4);
            avletree.Add(5);
            avletree.Add(4);
            avletree.Add(3);
            avletree.Delete(3);
            avletree.Delete(3);
            avletree.Add(1);
            avletree.Add(6);
            avletree.Add(5);
            avletree.Add(2);


            bool exist = avletree.Search(3);
            Assert.AreEqual(false, exist);

        }

        [TestMethod]
        public void TestSearchMin()
        {
            AVLTree<int> avletree = new AVLTree<int>(Comparer<int>.Default);

            avletree.Add(1);
            avletree.Add(2);
            avletree.Add(3);
            avletree.Add(4);
            avletree.Add(5);
            avletree.Add(4);
            avletree.Add(3);
            avletree.Delete(3);
            avletree.Delete(3);
            avletree.Add(1);
            avletree.Add(6);
            avletree.Add(5);
            avletree.Add(2);


            int min = avletree.SearchMin();
            Assert.AreEqual(1, min);

        }

        [TestMethod]
        public void TestTree()
        {
            AVLTree<int> avletree = new AVLTree<int>(Comparer<int>.Default);

            avletree.Add(1);
            avletree.Add(2);
            avletree.Add(3);
            Assert.Fail();
            //Assert.AreEqual(2,avletree.)

        }
    }
}
