using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;


namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        ///////ToString Method Override
        
        ////// - A List of strings returns expected result
        ////// - A List of ints returns expected result
        ////// - An empty list returns an empty string

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
            Assert.IsTrue("Testing the ToString method." == newStringFromList);
        }
        [TestMethod]
        public void ToString_listOfInts_returnsStringOfInts()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            

            // Act
            string newStringFromInts = intList.ToString();


            // Assert
            Assert.IsTrue("1 2 3 4 5" == newStringFromInts);
        }
        [TestMethod]
        public void ToString_blankList_returnsBlankString()
        {
            // Arrange
            CustomList<int> intList = new CustomList<int>();


            // Act
            string newStringBlank = intList.ToString();


            // Assert
            Assert.IsTrue("" == newStringBlank);
        }

    }
}
