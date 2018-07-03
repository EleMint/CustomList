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
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(16);
            // Act
            customList.Remove(16);
            // Assert
            Assert.AreEqual(customList.arrayCount, 0);
        }
        [TestMethod]
        public void TwoIndex_Remove()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(16);
            customList.Add(4);
            // Act
            customList.Remove(16);
            customList.Remove(4);
            // Assert
            Assert.AreEqual(customList.arrayCount, 0);
        }
        [TestMethod]
        public void TwoIndexOneElement_Remove()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(16);
            // Act
            customList.Remove(16);
            customList.Remove(4);
            // Assert
            Assert.AreEqual(customList.arrayCount, 0);
        }
        [TestMethod]
        public void ThreeIndex_Remove()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(17);
            customList.Add(16);
            customList.Add(4);
            customList.Add(6);
            // Act
            customList.Remove(16);
            customList.Remove(4);
            customList.Remove(6);
            // Assert
            Assert.AreEqual(customList[0], 17);
        }
        [TestMethod]
        public void ThreeIndexTwoElements_Remove()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(4);
            customList.Add(6);
            // Act
            customList.Remove(16);
            customList.Remove(4);
            customList.Remove(6);
            // Assert
            Assert.AreEqual(customList.arrayCount, 0);
        }
    }
}
