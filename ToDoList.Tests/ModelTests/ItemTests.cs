
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      //Act
      string result = newItem.GetDescription();
      // Assert
      Assert.AreEqual(description,result);
    }

  }
}
