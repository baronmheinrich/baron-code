using System;
using Xunit;
using PalindromeApp.Src;

namespace PalindromeApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMyPinendrome()
        {
            var P1 = new MyPalindrome(){Phrase = "racecar"};
            var actual = PalindromeChecker.PalindromeCheck(P1);
            Assert.True(actual);
        }
    }
}
