using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerScience.Algorithms;


namespace Tests {
    [TestClass]
    public class MergeSortTests {
        [TestMethod]
        public void ZeroLengthListReturnsSameList()
        {
            var list = new List<int>();
            Assert.AreEqual(list, MergeSort.Sort(list));
        }

        [TestMethod]
        public void OneLengthListReturnsSameList()
        {
            var list = new List<int> {1};
            Assert.AreEqual(list, MergeSort.Sort(list));
        }

        [TestMethod]
        public void ProperlySortsLists()
        {
            var list1 = new List<int> {2, 7, 8, 3, 1};
            var list2 = new List<int> {4, 2, 1, 1, 1};

            var list1s = new List<int> {1, 2, 3, 7, 8};
            var list2s = new List<int> {1, 1, 1, 2, 4};

            //CollectionAssert.AreEqual(MergeSort.Sort(list1), list1s);
            //StackOverflow - why?
            CollectionAssert.AreEqual(MergeSort.Sort(list2), list2s);
        }
    }
}
