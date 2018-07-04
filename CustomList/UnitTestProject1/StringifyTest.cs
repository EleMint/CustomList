using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class StringifyTest
    {
        [TestMethod]
        public void OneIndex_Stringify()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(100);

            string actual = customList.Stringify();

            Assert.AreEqual("100", actual);
        }
        [TestMethod]
        public void TwoIndex_Stringify()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(100);
            customList.Add(80);

            string actual = customList.Stringify();

            Assert.AreEqual("100, 80", actual);
        }
        [TestMethod]
        public void TwoIndexBool_Stringify()
        {
            CustomList<bool> customList = new CustomList<bool>();
            customList.Add(true);
            customList.Add(false);

            string actual = customList.Stringify();

            Assert.AreEqual("True, False", actual);
        }
        [TestMethod]
        public void SixIndexBool_Stringify()
        {
            CustomList<bool> customList = new CustomList<bool>();
            customList.Add(true);
            customList.Add(false);
            customList.Add(true);
            customList.Add(false);
            customList.Add(true);
            customList.Add(false);

            string actual = customList.Stringify();

            Assert.AreEqual("True, False, True, False, True, False", actual);
        }
        [TestMethod]
        public void TwoIndexString_Stringify()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("There");

            string actual = customList.Stringify();

            Assert.AreEqual("hello, There", actual);
        }
    }
}
