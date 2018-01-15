using System;
using CodingInterview.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingInterview_Test
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void TestMergeSort()
        {
            int[] testArr = { 3, 54, 456, 9, 27, 91, 3945, 2 };
            var ms = new MergeSort();
            var resArr = ms.sort(testArr);

            Array.Sort(testArr);
            Assert.AreEqual(testArr, resArr);
        }
    }
}
