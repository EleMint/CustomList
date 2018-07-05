using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void TwoInt_Sort()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(3);
            customList.Add(1);

            CustomList<int> actual = customList.Sort();

            Assert.AreEqual(customList.curArray[1], actual.curArray[0]);
            Assert.AreEqual(customList.curArray[0], actual.curArray[1]);
        }
    }
}
