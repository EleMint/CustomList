using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void OneSixInt_Zip()
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);

            CustomList<int> customList3 = customList.Zip(customList2);

            Assert.AreEqual(customList3[0], 1);
            Assert.AreEqual(customList3[1], 2);
            Assert.AreEqual(customList3[2], 3);
            Assert.AreEqual(customList3[3], 4);
            Assert.AreEqual(customList3[4], 5);
            Assert.AreEqual(customList3[5], 6);
        }
        [TestMethod]
        public void OneSixString_Zip()
        {
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customList.Add("1");
            customList.Add("3");
            customList.Add("5");
            customList2.Add("2");
            customList2.Add("4");
            customList2.Add("6");

            CustomList<string> customList3 = customList.Zip(customList2);

            Assert.AreEqual(customList3[0], "1");
            Assert.AreEqual(customList3[1], "2");
            Assert.AreEqual(customList3[2], "3");
            Assert.AreEqual(customList3[3], "4");
            Assert.AreEqual(customList3[4], "5");
            Assert.AreEqual(customList3[5], "6");
        }
        [TestMethod]
        public void BoolTest_Zip()
        {
            CustomList<bool> customList = new CustomList<bool>();
            CustomList<bool> customList2 = new CustomList<bool>();
            customList.Add(true);
            customList.Add(true);
            customList.Add(true);
            customList2.Add(false);
            customList2.Add(false);
            customList2.Add(false);

            CustomList<bool> customList3 = customList.Zip(customList2);

            Assert.AreEqual(customList3[0], true);
            Assert.AreEqual(customList3[1], false);
            Assert.AreEqual(customList3[2], true);
            Assert.AreEqual(customList3[3], false);
            Assert.AreEqual(customList3[4], true);
            Assert.AreEqual(customList3[5], false);
        }
    }
}
