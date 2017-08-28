using System;
using System.Collections.Generic;

namespace QATest.Src
{

    public static class Contacts
    {
      private static List<Person> pList = new List<Person>();

    
      public static bool Add(Person p)
      {
        try
        {
          pList.Add(p);
          return true;
        }
        catch
        {
          return false;
        }
      }

      public static Person Update(Person p)
      {
        //Find() is like using foreach
        var co = pList.Find(item => item.Id == p.Id);

        if(co != null)
        {
          co = p;
        }

        return co != null ? co : null;
      }




      public static void Delete()
      {

      }

      public static List<Person> List()
      {
        return pList;

      }

    }

}