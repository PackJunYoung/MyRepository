using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace OdbcExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string myConnString = "DRIVER=MysqlODBC;SERVER=MyServer;Trusted_connection=yes;DATABASE=shopdb;";
                OdbcConnection myConnection = new OdbcConnection(myConnString);
                myConnection.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            SqlConnection connection = new SqlConnection("");

            Console.ReadLine();
        }
    }
}
