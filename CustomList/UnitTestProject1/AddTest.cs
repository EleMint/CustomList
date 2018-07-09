using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void OneIndex_Add()
        {
            
            CustomList<int> customList = new CustomList<int>();
            
            customList.Add(16);
            int actual = customList[0];
            
            Assert.AreEqual(16, actual);
        }
        [TestMethod]
        public void TwoIndex_Add()
        {
            
            CustomList<int> customList = new CustomList<int>();
            int expected0 = 16;
            int expected1 = 13;
            
            customList.Add(expected0);
            customList.Add(expected1);
            int actual0 = customList[0];
            int actual1 = customList[1];
            
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
        }
        [TestMethod]
        public void ThreeIndex_Add()
        {
            
            CustomList<int> customList = new CustomList<int>();
            int expected0 = 16;
            int expected1 = 14;
            int expected2 = 13;
            
            customList.Add(expected0);
            customList.Add(expected1);
            customList.Add(expected2);
            int actual0 = customList[0];
            int actual1 = customList[1];
            int actual2 = customList[2];
            
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestMethod]
        public void NineIndex_Add()
        {
            
            CustomList<int> customList = new CustomList<int>();
            int expected0 = 1;
            int expected1 = 6;
            int expected2 = 3;
            int expected3 = 16;
            int expected4 = 17;
            int expected5 = 12;
            int expected6 = 14;
            int expected7 = 18;
            int expected8 = 0;
            
            customList.Add(expected0);
            customList.Add(expected1);
            customList.Add(expected2);
            customList.Add(expected3);
            customList.Add(expected4);
            customList.Add(expected5);
            customList.Add(expected6);
            customList.Add(expected7);
            customList.Add(expected8);
            int actual0 = customList[0];
            int actual1 = customList[1];
            int actual2 = customList[2];
            int actual3 = customList[3];
            int actual4 = customList[4];
            int actual5 = customList[5];
            int actual6 = customList[6];
            int actual7 = customList[7];
            int actual8 = customList[8];
            
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
            Assert.AreEqual(expected6, actual6);
            Assert.AreEqual(expected7, actual7);
            Assert.AreEqual(expected8, actual8);
        }
        [TestMethod]
        public void TenIndex_Add()
        {
            
            CustomList<int> customList = new CustomList<int>();
            int expected0 = 16;
            int expected1 = 6;
            int expected2 = 1;
            int expected3 = 2;
            int expected4 = 4;
            int expected5 = 3;
            int expected6 = 44;
            int expected7 = 100;
            int expected8 = 18;
            int expected9 = 19;
            
            customList.Add(expected0);
            customList.Add(expected1);
            customList.Add(expected2);
            customList.Add(expected3);
            customList.Add(expected4);
            customList.Add(expected5);
            customList.Add(expected6);
            customList.Add(expected7);
            customList.Add(expected8);
            customList.Add(expected9);
            int actual0 = customList[0];
            int actual1 = customList[1];
            int actual2 = customList[2];
            int actual3 = customList[3];
            int actual4 = customList[4];
            int actual5 = customList[5];
            int actual6 = customList[6];
            int actual7 = customList[7];
            int actual8 = customList[8];
            int actual9 = customList[9];

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
            Assert.AreEqual(expected6, actual6);
            Assert.AreEqual(expected7, actual7);
            Assert.AreEqual(expected8, actual8);
            Assert.AreEqual(expected9, actual9);
        }
        [TestMethod]
        public void OneIndexObject_Add()
        {

            CustomList<object> customList = new CustomList<object>();
            Object myObject = new Object();

            customList.Add(myObject);
            object actual = customList[0];

            Assert.AreEqual(myObject, actual);
        }
    }
}
