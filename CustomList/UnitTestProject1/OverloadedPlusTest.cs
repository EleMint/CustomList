using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class OverloadedPlusTest
    {
        [TestMethod]
        public void TwoSingleIndex_Plus()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(14);
            customList2.Add(22);

            CustomList<int> actual = customList + customList2;

            Assert.AreEqual(customList.curArray[0], actual.curArray[0]);
            Assert.AreEqual(customList2.curArray[0], actual.curArray[1]);
        }
        [TestMethod]
        public void MultiIndex_Plus()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(14);
            customList.Add(14);
            customList.Add(14);
            customList.Add(14);
            customList.Add(14);
            customList2.Add(22);
            customList2.Add(22);
            customList2.Add(22);
            customList2.Add(22);
            customList2.Add(22);

            CustomList<int> actual = customList + customList2;

            Assert.AreEqual(customList.curArray[0], actual.curArray[0]);
            Assert.AreEqual(customList.curArray[1], actual.curArray[1]);
            Assert.AreEqual(customList.curArray[2], actual.curArray[2]);
            Assert.AreEqual(customList.curArray[3], actual.curArray[3]);
            Assert.AreEqual(customList.curArray[4], actual.curArray[4]);
            Assert.AreEqual(customList2.curArray[0], actual.curArray[5]);
            Assert.AreEqual(customList2.curArray[1], actual.curArray[6]);
            Assert.AreEqual(customList2.curArray[2], actual.curArray[7]);
            Assert.AreEqual(customList2.curArray[3], actual.curArray[8]);
            Assert.AreEqual(customList2.curArray[4], actual.curArray[9]);
        }
        [TestMethod]
        public void TwoSingleIndexString_Plus()
        {
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customList.Add("14");
            customList2.Add("22");

            CustomList<string> actual = customList + customList2;

            Assert.AreEqual(customList.curArray[0], actual.curArray[0]);
            Assert.AreEqual(customList2.curArray[0], actual.curArray[1]);
        }
        [TestMethod]
        public void MultiIndexString_Plus()
        {
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customList.Add("14");
            customList.Add("14");
            customList.Add("14");
            customList.Add("14");
            customList.Add("14");
            customList2.Add("22");
            customList2.Add("22");
            customList2.Add("22");
            customList2.Add("22");
            customList2.Add("22");

            CustomList<string> actual = customList + customList2;

            Assert.AreEqual(customList.curArray[0], actual.curArray[0]);
            Assert.AreEqual(customList.curArray[1], actual.curArray[1]);
            Assert.AreEqual(customList.curArray[2], actual.curArray[2]);
            Assert.AreEqual(customList.curArray[3], actual.curArray[3]);
            Assert.AreEqual(customList.curArray[4], actual.curArray[4]);
            Assert.AreEqual(customList2.curArray[0], actual.curArray[5]);
            Assert.AreEqual(customList2.curArray[1], actual.curArray[6]);
            Assert.AreEqual(customList2.curArray[2], actual.curArray[7]);
            Assert.AreEqual(customList2.curArray[3], actual.curArray[8]);
            Assert.AreEqual(customList2.curArray[4], actual.curArray[9]);
        }
    }
}
