using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{ 
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void OneIndex_Remove()
        {

            CustomList<int> customList = new CustomList<int>();
            customList.Add(16);

            customList.Remove(16);

            Assert.AreEqual(customList.Count, 0);
        }
        [TestMethod]
        public void TwoIndex_Remove()
        {

            CustomList<int> customList = new CustomList<int>();
            customList.Add(16);
            customList.Add(4);

            customList.Remove(16);
            customList.Remove(4);

            Assert.AreEqual(customList.Count, 0);
        }
        [TestMethod]
        public void TwoIndexOneElement_Remove()
        {

            CustomList<int> customList = new CustomList<int>();
            customList.Add(16);

            customList.Remove(16);
            customList.Remove(4);

            Assert.AreEqual(customList.Count, 0);
        }
        [TestMethod]
        public void ThreeIndex_Remove()
        {

            CustomList<int> customList = new CustomList<int>();
            customList.Add(17);
            customList.Add(16);
            customList.Add(4);
            customList.Add(6);

            customList.Remove(16);
            customList.Remove(4);
            customList.Remove(6);

            Assert.AreEqual(customList[0], 17);
        }
        [TestMethod]
        public void ThreeIndexTwoElements_Remove()
        {

            CustomList<int> customList = new CustomList<int>();
            customList.Add(4);
            customList.Add(6);

            customList.Remove(16);
            customList.Remove(4);
            customList.Remove(6);

            Assert.AreEqual(customList.Count, 0);
        }
    }
}
