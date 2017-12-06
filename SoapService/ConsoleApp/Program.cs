using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void PersonLib()
        {
            var ps = new List<Person>()
            {
                new Person {FName="Debbie", LName="Baraknowska"},
                new Person {FName="Orpolar", LName="Baraknowska"},
                new Person {FName="Amy", LName="Baraknowska"}

            };
        }
    }
}
