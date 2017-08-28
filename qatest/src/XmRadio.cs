using System;
using System.Threading;

namespace QATest.Src
{
  public class XmRadio
  {

    public delegate void RadioSignal();
    public event RadioSignal MicHandler;

    private static XmRadio _instance;

    private XmRadio()
    {
      _instance = new XmRadio();
    }

    public static XmRadio Instance{
      get
      {
        if(_instance == null)
        {
         _instance = new XmRadio();
        }
        return new XmRadio();
      } 
    }

    public void Broadcast()
    {
      var count = 0;
      while(count<6)
      {
        Thread.Sleep(2000);
        System.Console.WriteLine("What's Good Playa? Talk to me!");

        if(MicHandler != null)
        {
          MicHandler();
        }
        count += 1;


      }
    }

    internal void Subscribe(XmRadio r)
    {
      throw new NotImplementedException();
    }
  }

}