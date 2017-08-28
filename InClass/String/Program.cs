using System;
using System.Text;


    
        class Program //default is internal
    {
        static void Main(string[] args) //default is private
        {
            
            string string1 = "";
            string string2 = "";
            string string3 = "";
            int BigCount = 0;
            int SmallCount = 0;
            Boolean Big1 = false;
            Boolean Big2 = false;

            Console.WriteLine("Enter your first string");
            string1 = Console.ReadLine();

            Console.WriteLine("Enter your second string");
            string2 = Console.ReadLine();

            if(string1.Length ==string2.Length)
            {
                BigCount = string1.Length;
                SmallCount = string2.Length;
            }
            else if(string1.Length > string2.Length)
            {
                BigCount = string1.Length;
                SmallCount = string2.Length;
                Big1 = true;
            }
            else if(string1.Length < string2.Length)
            {
                BigCount = string2.Length;
                SmallCount = string1.Length;
                Big2 = true;
            }


              for(int j=0; j<SmallCount; j++)
              {
                  string3 = string3 + string1[j] + string2[j];
              }

              for(int i=BigCount-SmallCount; i<BigCount; i++)
              {
                  if(Big1==true)
                  {
                      string3 = string3 +string1[i];
                  }
                    else if(Big2==true)
                    {
                        string3=string3 + string2[i];
                    }
                    else
                    {
                        break;
                    }

              }
              

        Console.WriteLine(string3);

        }

    }

