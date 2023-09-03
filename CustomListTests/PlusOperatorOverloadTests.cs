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
    }
}
