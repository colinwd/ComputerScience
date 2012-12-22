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
            var list = new List<int>();
            list.Add(1);
            Assert.AreEqual(list, MergeSort.Sort(list));
        }
    }
}
