using QATest.Src;
using Xunit;

namespace ToDo.Test
{
    public class ToDoList
    {

      [Fact]
      createItemTest()
      {

        var i = new ItemList();
        var test = ItemList.add(i);

        Assert.true(test);

      }

      [Fact]
      readItemTest()
      {

      }

      [Fact]
      updateItemTest()
      {

      }

      [Fact]
      deleteItemTest()
      {

      }

      [Fact]
      completeItemTest()
      {

      }



    }
}