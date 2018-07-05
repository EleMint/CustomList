using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void OneIndex_ToString()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(100);

            string actual = customList.ToString();

            Assert.AreEqual("100", actual);
        }
        [TestMethod]
        public void TwoIndex_ToString()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(100);
            customList.Add(80);

            string actual = customList.ToString();

            Assert.AreEqual("100, 80", actual);
        }
        [TestMethod]
        public void TwoIndexBool_ToString()
        {
            CustomList<bool> customList = new CustomList<bool>();
            customList.Add(true);
            customList.Add(false);

            string actual = customList.ToString();

            Assert.AreEqual("True, False", actual);
        }
        [TestMethod]
        public void SixIndexBool_ToString()
        {
            CustomList<bool> customList = new CustomList<bool>();
            customList.Add(true);
            customList.Add(false);
            customList.Add(true);
            customList.Add(false);
            customList.Add(true);
            customList.Add(false);

            string actual = customList.ToString();

            Assert.AreEqual("True, False, True, False, True, False", actual);
        }
        [TestMethod]
        public void TwoIndexString_ToString()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("There");

            string actual = customList.ToString();

            Assert.AreEqual("hello, There", actual);
        }
    }
}
