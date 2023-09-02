using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{

    [TestClass]
    public class RemoveMethodTests
    {
       
        [TestMethod]
        public void Remove_ItemAInArray_ItemAIsRemovedFromArray()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("d");

            // Act
            customList.Remove("a");
            int a_Count = 0;
            foreach (string item in customList.Items) 
            {
                if (item == "a")
                {
                    a_Count++;
                }
            }
            // Assert
            Assert.AreEqual(0, a_Count);
        }
        
        [TestMethod]
        public void Remove_ItemRemovedSuccess_ReturnsTrue()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("d");
            // Act
            customList.Remove("a");
            // Assert
            Assert.IsTrue(customList.Count == 3);
        }
        [TestMethod]
        public void Remove_AttemptRemovingItemNotInList_ReturnsFalse()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("d");
            // Act
            customList.Remove("e");
            // Assert
            Assert.IsFalse(customList.Count == 3);
        }

        [TestMethod]
        public void Remove_CountWhenTryingToRemoveItemNotInList_RemainsUnchanged()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("d");
            // Act
            customList.Remove("e");
            // Assert
            Assert.AreEqual(4, customList.Count);
        }
        [TestMethod]
        public void Remove_IndexOfItemInIndex2WhenItemInIndex1Removed_ItemIsMovedToIndex1()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("d");
            // Act
            customList.Remove("b");
            // Assert
            Assert.AreEqual("c", customList.Items[1]);
        }
        [TestMethod]
        public void Remove_IndexOfItemInIndex3WhenItemInIndex2Removed_ItemIsMovedToIndex2()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("d");
            // Act
            customList.Remove("b");
            // Assert
            Assert.AreEqual("d", customList.Items[2]);
        }

        [TestMethod]
        public void Remove_MultipleInstancesOfItemCAfterRemovingC_OnlyFirstCRemovedOthersRemain()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");
            customList.Add("c");
            customList.Add("c");
            // Act
            customList.Remove("c");
            int c_Count = 0;
            foreach (string item in customList.Items)
            {
                if (item == "c")
                {
                    c_Count++;
                }
            }
            // Assert
            Assert.AreEqual(2, c_Count);
        }
    }

}
