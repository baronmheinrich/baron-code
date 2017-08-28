using System;
using PalindromeApp.Src;
using Xunit;

namespace PalindromeApp.Src
{
  public class PalindromeChecker
  {

    public static bool PalindromeCheck(MyPalindrome P)
    {

      int length = P.Phrase.length;
      string reverse = "";

      for(int i=length; i>length; i--)
      {
        reverse = P[length];
      }

      if(reverse==length)
      {
        return true;
      }
      else
      {
        return false;
      }


    }

  }
}