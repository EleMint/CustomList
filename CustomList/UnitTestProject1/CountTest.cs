using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class CountTest
    {
        [TestMethod]
        public void OneIndex_Count()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(14);

            Assert.AreEqual(customList.arrayCount, 1);
        }
        [TestMethod]
        public void TwoIndex_Count()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(14);
            customList.Add(16);

            Assert.AreEqual(customList.arrayCount, 2);
        }
    }
}
