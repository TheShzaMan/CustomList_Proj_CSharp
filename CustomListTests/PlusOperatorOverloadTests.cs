using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
        /// + Operator Overload
        ////    At least 3 tests
        ////    -First list is longer than second list
        ////    -Second list is longer than first list
        ////    -If one list is empty, result is unchanged


        [TestMethod]
        public void PlusOperator_ListTwoAddedToListOne_CombinedListHasAllItems()
        {
            // Arrange
            CustomList<string> listOne = new CustomList<string>() { "a", "b", "c" };
            CustomList<string> listTwo = new CustomList<string>() { "d", "e", "f" };

            // Act
            CustomList<string> comboList = listOne + listTwo;

            // Assert
            Assert.AreEqual(6, comboList.Count);
        }

        [TestMethod]
        public void PlusOperator_ListOneLargerThanListTwo_ComboListHasAllItemsFromBoth()
        {
            // Arrange
            CustomList<string> listOne = new CustomList<string>() { "a", "b", "c", "d" };
            CustomList<string> listTwo = new CustomList<string>() { "e", "f", "g" };

            // Act
            CustomList<string> comboList = listOne + listTwo;
            string stringOfItems = comboList.ToString();

            // Assert
            //Assert.AreEqual("a b c d e f g", stringOfItems);
            Assert.AreEqual(7, comboList.Count);
        }
        [TestMethod]
        public void PlusOperator_ListTwoLargerThanListOne_ComboListHasAllItemsFromBoth()
        {
            // Arrange
            CustomList<string> listOne = new CustomList<string>() { "a", "b", "c" };
            CustomList<string> listTwo = new CustomList<string>() { "d", "e", "f", "g" };

            // Act
            CustomList<string> comboList = listOne + listTwo;
            string stringOfItems = comboList.ToString();

            // Assert
            Assert.AreEqual("a b c d e f g", stringOfItems);
        }
        [TestMethod]
        public void PlusOperator_ListTwoIsEmpty_ComboListHasAllItemsFromListOne()
        {
            // Arrange
            CustomList<string> listOne = new CustomList<string>() { "a", "b", "c" };
            CustomList<string> listTwo = new CustomList<string>();

            // Act
            CustomList<string> comboList = listOne + listTwo;
            string stringOfItems = comboList.ToString();

            // Assert
            Assert.AreEqual("a b c", stringOfItems);
        }
    }
}
