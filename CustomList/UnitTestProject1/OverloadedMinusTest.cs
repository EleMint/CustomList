using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class OverloadedMinusTest
    {
        [TestMethod]
        public void MultiIndex_Minus()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(14);
            customList.Add(14);
            customList.Add(4);
            customList.Add(14);
            customList.Add(14);
            customList.Add(100);
            customList2.Add(22);
            customList2.Add(22);
            customList2.Add(14);
            customList2.Add(4);
            customList2.Add(22);

            CustomList<int> actual = customList - customList2;

            Assert.AreEqual(actual.Count, 1);
        }
        [TestMethod]
        public void OneIndexSubtract_Minus()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(1);
            customList2.Add(1);

            CustomList<int> actual = customList - customList2;

            Assert.AreEqual(actual.Count, 0);
        }
        [TestMethod]
        public void TwoIndexSubtractOne_Minus()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList2.Add(1);

            CustomList<int> actual = customList - customList2;

            Assert.AreEqual(actual.Count, 1);
            Assert.AreEqual(actual.curArray[0], 2);
        }
        [TestMethod]
        public void ThreeIndexSubtractTwo_Minus()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList2.Add(3);
            customList2.Add(1);

            CustomList<int> actual = customList - customList2;

            Assert.AreEqual(actual.Count, 1);
            Assert.AreEqual(actual.curArray[0], 2);
        }
    }
}
