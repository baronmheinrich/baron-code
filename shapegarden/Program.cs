using System;
using ShapeGarden.Interfaces;
using ShapeGarden.Models;

namespace shapegarden
{
    class Program //default is internal
    {
        static void Main(string[] args) //default is private
        {
            var p = new Program();
            p.PlayWithShapes();
        }

        public void PlayWithShapes()
        {
            Rectangle r1 =  new Rectangle();
            AShape a1 = new Square(); // An object that is a a square but represents itself as an AShape. 

            Console.WriteLine(r1.Sides)
        }

        public static void PrintShapes(params IShape[] r)
        {

            try
            {
                foreach(var item in r)
                {
                    Console.WriteLine(item.Sides);
                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("whats good playa talk to me");
            }
            catch(Exception ex)
            {
                throw new Exception("message", ex);
            }
            finally
            {
                //The only time finally doens't execute is if there's a fatal error that the program can't recover
                //like a memory issue 
                GC.Collect();
            }
        }
    }
}
