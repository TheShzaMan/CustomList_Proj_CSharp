using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToString_listOfStrings_returnsString()
        {
            // Arrange
            CustomList<string> stringList = new CustomList<string>();
            stringList.Add("Testing");
            stringList.Add("the");
            stringList.Add("ToString");
            stringList.Add("method.");

            // Act
            string newStringFromList = stringList.ToString();
            
            
            // Assert
            Assert.IsTrue("Testing the ToString method. " == newStringFromList);
        }
        [TestMethod]
        public void ToString_listOfInts_returnsStringOfInts()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int> { 1, 2, 3, 4, 5};
            

            // Act
            string newStringFromInts = intList.ToString();


            // Assert
            Assert.IsTrue("1 2 3 4 5 " == newStringFromInts);
        }
        [TestMethod]
        public void ToString_blankList_returnsBlankString()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();


            // Act
            string newStringBlank = intList.ToString();


            // Assert
            Assert.IsTrue(" " == newStringBlank);
        }

    }
}
