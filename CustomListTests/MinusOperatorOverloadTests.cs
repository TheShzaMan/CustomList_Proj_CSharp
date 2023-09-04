using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTests
    {
        [TestMethod]
        public void MinusOperator_SecondListSubtractedFromFirst_NewListOnlyContainsItemsthatWerentSubtracted()
        {
            // Arrange
            CustomList<string> firstList = new CustomList<string>() { "a", "b", "c", "a", "b"};
            CustomList<string> secondList = new CustomList<string>() { "b", "c", "a",};

            // Act
            CustomList<string> newList = firstList - secondList;
            string itemsInNewList = newList.ToString();
            // Assert
            Assert.AreEqual("a b", itemsInNewList); 
        }

        [TestMethod]
        public void MinusOperator_LargerSecondListSubtractedFromSmallerFirst_NewListOnlyContainsItemsthatWerentSubtracted()
        {
            // Arrange
            CustomList<string> firstList = new CustomList<string>() { "a", "b", "c" };
            CustomList<string> secondList = new CustomList<string>() { "b", "c", "d", "g", "e", "f"};

            // Act
            CustomList<string> newList = firstList - secondList;
            string itemsInNewList = newList.ToString();
            // Assert
            Assert.AreEqual("a", itemsInNewList);
        }

        [TestMethod]
        public void MinusOperator_SecondListIsBlankAndSubtracted_NewListSameAsFirstList()
        { 
            // Arrange
            CustomList<string> firstList = new CustomList<string>() { "a", "b", "c", "a", "b" };
            CustomList<string> secondList = new CustomList<string>() { "b", "c", "a", };

            // Act
            CustomList<string> newList = firstList - secondList;
            string itemsInNewList = newList.ToString();
            // Assert
            Assert.AreEqual(firstList, newList);
        }
        [TestMethod]
        public void MinusOperator_AnItemOnlySubtractsOneInstanceIfMultiplePresent_OnlyOneInstanceRemoved()
        {
            // Arrange
            CustomList<string> firstList = new CustomList<string>() { "a", "a", "a"};
            CustomList<string> secondList = new CustomList<string>() { "a" };

            // Act
            CustomList<string> newList = firstList - secondList;
            string itemsInNewList = newList.ToString();
            // Assert
            Assert.AreEqual("a a", itemsInNewList);
        }
    }
}
