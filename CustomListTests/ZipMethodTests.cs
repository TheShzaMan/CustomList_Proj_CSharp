using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ZipMethodTests
    {
        [TestMethod]
        public void ZipMethod_SecondListCombinesWithFirst_OneListWithSixCount()
        {
            //Arrange
            CustomList<string> firstList = new CustomList<string>() { "the", "lists", "been" };
            CustomList<string> secondList = new CustomList<string>() { "two", "have", "zipped" };
            //Act
            firstList.Zip(secondList);
            
            //Assert
            Assert.AreEqual(6, firstList.Count);
        }
        [TestMethod]
        public void ZipMethod_ItemThatWasIndexZeroInSecondListBeforeZipping_NowFirstListIndexOne()
        {
            //Arrange
            CustomList<string> firstList = new CustomList<string>() { "the", "lists", "been" };
            CustomList<string> secondList = new CustomList<string>() { "two", "have", "zipped" };
            //Act
            firstList.Zip(secondList);

            //Assert
            Assert.AreEqual("two", firstList[1]);
        }
        [TestMethod]
        public void ZipMethod_ItemThatWasIndexOneInFirstListBeforeZipping_NowFirstListIndexTwo()
        {
            //Arrange
            CustomList<string> firstList = new CustomList<string>() { "the", "lists", "been" };
            CustomList<string> secondList = new CustomList<string>() { "two", "have", "zipped" };
            //Act
            firstList.Zip(secondList);

            //Assert
            Assert.AreEqual("lists", firstList[2]);
        }
    }
}
