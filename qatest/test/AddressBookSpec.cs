using System;
using Machine.Specifications;
using QATest.Src;
using FluentAssertions;

namespace QATest.Test
{
  public class When_Testing_AddressBook
  {

    private static Person p = new Person();

    private Establish context = () =>
    {
      p = new Person(){Id = 0, First = "fred", Last = "belotte"};
    };

    private Because of = () =>
    {
      Contacts.Add(p);
    };

    private It should_have_a_person = () =>
    {

      Contacts.List().Count.Should().Be(1);
      Contacts.List().Find(c => c.Id == p.Id).Should().NotBeNull();

      // if(Contacts.List().Count >= 1)
      // {
      //   throw new Exception();
      // }
      if(Contacts.List().Find(c => c.Id == p.Id) == null)
      {
        throw new Exception();
      }
    };


  }

}