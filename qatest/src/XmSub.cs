
using QATest.Src;
namespace QATest
{

  public class XmSub
  {

    public void Subscribe(XmRadio r)
    {
      r.MicHandler += Listening;
    }

    public void Unsubscribe(XmRadio r)
    {
      r.MicHandler -= Listening;
    }

    private void Listening()
    {
      System.Console.WriteLine("My Neck, My Back");
    }
  }

}