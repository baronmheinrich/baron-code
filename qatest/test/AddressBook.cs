using System;
using QATest.Src;
using Xunit;

namespace QATest.Test
{
  public class AddressBook
  {



    //[Fact]
    public void AddTest()
    {

      // arrange
      var p = new Person ();

      // act 
      var actual = Contacts.Add(p);

      // assert
      Assert.True(actual);

    }

    
    public void UpdateTest()
    {

      Person p = new Person(){Id=1, First="fred", Last = "belotte"};

      Person actual = Contacts.Update(p);
      Assert.Equal(actual.Id, p.Id);
      Assert.Equal(actual.First, p.First);
      Assert.Equal(actual.Last, p.Last);

    }

    //[Fact]
    public void DeleteTest()
    {

    }

    //[Fact]
    public void ListTest()
    {

    }

    public void CheckLocale()
    {
      var p = new Person ();
      //p.DisplayName(USFullName);
    }

    Func<string, string, string> USFullName = (string first, string last) => {return first + " " + last;};
    Func<string, string, string> EUFullName = (string first, string last) => {return last + " " + first;};

    Action<string, string> FullName = (string q, string w) => {};

  }
}