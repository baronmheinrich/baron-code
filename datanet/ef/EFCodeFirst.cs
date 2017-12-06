using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using datanet.ef;


namespace datanet.ef
{

  public class SqlWeek3 : DbContext
  {

    public DbSet<Contact> Contacts{get;set;}
    public DbSet<Phone> Phones{get;set;}
    public DbSet<Email> Emails{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      
      builder.UseSqlServer("data source=mysqlweek1.database.windows.net;initial catalog=baronsqlweek1;user id=sqladmin001;password=MyPassword1!;");
    }

  }

  public class Contact
  {
    //[Key]
    public int ContactId{get;set;}
    public string First{get; set;}
    public string Last{get; set;}
    
     public override string ToString()
        {
            return string.Format("{0}{1}", First, Last);
        }
  }

  public class Phone
  {
    public int PhoneId{get; set;}
    public Contact Contact{get; set;}
    public string Number{get;set;}
  }

  public class Email
  {
    public int EmailId{get;set;}
    public Contact Contact {get;set;}

    public string EmailAddress{get;set;}
  }

}