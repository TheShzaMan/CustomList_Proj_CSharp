using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        public void Add_NewItemAdded_CountIncreases()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();

            // Act
            customList.Add("item");

            // Assert
            Assert.AreEqual(1, customList.Count);
        }
        [TestMethod]
        public void Add_FirstItemAdded_ItemIsFoundInIndex0()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            
            // Act
            customList.Add("item");

            // Assert
            Assert.AreEqual("item", customList.Items[0]);
        }
        [TestMethod]
        public void Add_SecondItemAdded_ItemIsFoundInIndex1()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();

            // Act
            customList.Add("item1");
            customList.Add("item2");

            // Assert
            Assert.AreEqual("item2", customList.Items[1]);
        }
        [TestMethod]
        public void Add_ItemAddedExceedsCapacityValue_CapacityDoubles()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();
            
            // Act
            customList.Add("A");
            customList.Add("B");
            customList.Add("C");
            customList.Add("D");
            customList.Add("E");

            // Assert
            Assert.AreEqual(8, customList.Capacity);
        }
        [TestMethod]
        public void Add_ItemBIndexAfterCapacityIncrease_RemainsAt1()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();

            // Act
            customList.Add("A");
            customList.Add("B");
            customList.Add("C");
            customList.Add("D");
            customList.Add("E");

            // Assert
            Assert.AreEqual("B", customList.Items[1]);
        }
    }




}