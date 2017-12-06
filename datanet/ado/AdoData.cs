using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Datanet.Ado
{
    public class AdoData
    {
      private string connection = "data source=mysqlweek1.database.windows.net;initial catalog=baronsqlweek1;user id=sqladmin001;password=MyPassword1!;";
      public void ReadDisconnected()
      {


        DataSet ds = new DataSet();
        string query = "select * from SalesLT.Customer;";
        SqlCommand command = new SqlCommand(query);
        SqlDataAdapter da =new SqlDataAdapter();

        using(var con = new SqlConnection(connection))
        {
          command.Connection = con;
          da.SelectCommand = command;
          con.Open();
          da.Fill(ds);
        }

        foreach(DataRow item in ds.Tables[0].Rows)
        {
          System.Console.WriteLine("{0} {1}", item[3], item["lastname"]);
        }

      }

    public void ReadConnected()
    {
      using(var con = new SqlConnection(connection))
      {
        SqlDataReader dr;

        var q = "select * from SalesLt.Customer;";
        var command = new SqlCommand(q);

        con.Open();
        command.Connection = con;
        dr = command.ExecuteReader();

        while(dr.Read())
        {
          System.Console.WriteLine("{0}{1}", dr[3], dr["LastName"]);
          Thread.Sleep(100);
        }

       

      }
    }

    }
}