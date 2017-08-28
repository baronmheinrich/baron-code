using System.Threading;
using QATest.Src;
using Xunit;

namespace QATest
{

  public class Startup
  {
    public static void Main()
    {

     //EventStuff();
      //ThreadStuff();
      //TaskStuff();
      AsyncStuff();
      Thread.Sleep(3000);
    }

    public static void EventStuff()
    {

      var r = XmRadio.Instance;
      var s = new XmSub();

      r.Subscribe(r);
      r.Broadcast();
      s.Subscribe(r);
      r.Broadcast();
    }

    public static void ThreadStuff()
    {
      var ap = new AsyncPro();
      ap.ThreadParty();
    }

    public static void TaskStuff()
    {
      var ap = new AsyncPro();
      ap.TaskParty();
    }

    public static async void AsyncStuff()
    {
      var ap = new AsyncPro();

      await ap.AsyncParty();
      //Thread.Sleep(5000);
    }

    
  public static void Factory()
  {
    var g = new Gaming();
    var b = new Business();
  foreach(var item in g.stuff)
  {
    System.Console.WriteLine(item.GetType().FullName);
  }
  }

  public static void FactoryofFactories()
  {
    var n = new ComputerFactory();

    var g = n.Instance<Gaming>();
  }
  }
}