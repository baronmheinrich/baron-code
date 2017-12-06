using System;
using System.Linq;
using Datanet.Ado;
using datanet.ef;

namespace datanet.ef
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayWithAdo();
            PlayWithEFCodeFirst();
        }

        public static void PlayWithAdo()
        {
            var ado = new AdoData();
            //ado.ReadDisconnected();
            ado.ReadConnected();
        }

        public static void PlayWithEFCodeFirst()
        {
            var ef = new SqlWeek3();

            ef.Contacts.Add(new Contact(){First="fred", Last="belotte"});
            ef.SaveChanges();

            var contacts = ef.Contacts;

            System.Console.WriteLine(contacts.First());
        }

       public static void PlayWithEFDatabaseFirst()
       {
           var ef = new sqlweek1Context();

           ef.Contacts.Add(new Contacts(){ First = "fred1", Last="belotte1"});

           var contacts = ef.Contacts.ToList();

           System.Console.WriteLine(contacts.First());
       }
    }
}
