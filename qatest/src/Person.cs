using System;

namespace QATest.Src
{
  public class Person
  {

    public int Id { get; set; }
    public string First {get; set;}
    public string Last { get; set; }

    public delegate string NameFormat(string a, string z);
    public delegate void NameFormatBlank(string a, string z);

    //functions allow you to pass a method as an argument in another method
    //very useful for localization
    //first argument in the func is always the return type
    Func<string, string, string> USFullName = (string first, string last) => {return first + " " + last;};
    Func<string, string, string> EUFullName = (string first, string last) => {return last + " " + first;};


    //public void DisplayName(Func<string, string, string> name)
    public void DisplayName(NameFormat name)
    {
      System.Console.WriteLine(name(First,Last));
    }

  }

}