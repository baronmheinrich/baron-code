using QATest.Src;

namespace QATest.Src
{

  public class Newegg()
  {

  }

  public class ComputerFactory : Newegg
  {

    public Computer Instance<T>() where T : Computer , new()
    {
      var m = new Monitor();
      return new T();
    }

  }

  public class MonitorFactory : Newegg{}


}