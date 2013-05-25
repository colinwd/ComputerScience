using System;
using System.Collections.Generic;
using ComputerScience.Algorithms.Sorts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class InsertionSortTests {
        [TestMethod]
        public void ZeroLengthListReturnsSameList() {
            var list = new int[0];
            Assert.AreEqual(list, InsertionSort.Sort(list));
        }

        [TestMethod]
        public void OneLengthListReturnsSameList() {
            var list = new int[1];
            list[0] = 1;
            Assert.AreEqual(list, InsertionSort.Sort(list));
        }

        [TestMethod]
        public void ProperlySortsLists() {
            int[] list1 = new List<int> { 2, 7, 8, 3, 1 }.ToArray();
            int[] list2 = new List<int> { 4, 2, 1, 1, 1 }.ToArray();

            int[] list1s = new List<int> { 1, 2, 3, 7, 8 }.ToArray();
            int[] list2s = new List<int> { 1, 1, 1, 2, 4 }.ToArray();

            CollectionAssert.AreEqual(InsertionSort.Sort(list1), list1s);
            CollectionAssert.AreEqual(InsertionSort.Sort(list2), list2s);
        }
    }
}
