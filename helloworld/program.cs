using System;
using c = System.Console; //alias. ONLY works for objects
public class HelloWorld
{
public static void Main()
  {
    c.WriteLine("Miley, what's good?");
    //Fizz Buzz!
    // if divisable by 3 -> Fizz
    // if divisiable by 5 -> buzz
    // if divisable by 3 and 5 -> fizzbuzz
    // count 1-100
    // output how many fizz, buzz, and fizzbuzz

    int count = 1;
    int FizzCount = 0 ;
    int BuzzCount = 0;
    int FizzBuzzCount = 0;
    while(count<=100)
    {
      if(count%3==0)
      {
        FizzCount = FizzCount + 1;
      }

      if(count%5 == 0)
      {
        BuzzCount = BuzzCount + 1;
      }

      if(count%5 == 0 && count%3 == 0)
      {
        FizzBuzzCount = FizzBuzzCount + 1;
      }
      
      count = count + 1;

    }

    c.WriteLine("Fizz is " + FizzCount);
    c.WriteLine("Buzz is " + BuzzCount);
    c.WriteLine("FizzBuzz is " + FizzBuzzCount);


  }
}