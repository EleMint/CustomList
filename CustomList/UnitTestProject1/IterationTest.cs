using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class IterationTest
    {
        [TestMethod]
        public void OneIndex_Iteration()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(12);
            int total = 0;

            foreach(int index in customList)
            {
                total += index;
            }

            Assert.AreEqual(total, 12);
        }
        [TestMethod]
        public void TwoIndex_Iteration()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(12);
            customList.Add(2);
            int total = 0;

            foreach (int index in customList)
            {
                total += index;
            }

            Assert.AreEqual(total, 14);
        }
        [TestMethod]
        public void ThreeIndex_Iteration()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(12);
            customList.Add(2);
            customList.Add(100);
            int total = 0;

            foreach (int index in customList)
            {
                total += index;
            }

            Assert.AreEqual(total, 114);
        }
        [TestMethod]
        public void SevenIndex_Iteration()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(12);
            customList.Add(2);
            customList.Add(22);
            customList.Add(42);
            customList.Add(61);
            customList.Add(73);
            customList.Add(12);
            int total = 0;

            foreach (int index in customList)
            {
                total += index;
            }

            Assert.AreEqual(total, 224);
        }
    }
}
