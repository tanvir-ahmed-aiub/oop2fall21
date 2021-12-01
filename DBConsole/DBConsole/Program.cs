using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace DBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employees name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Employees address: ");
            string add = Console.ReadLine();

            //string connStr = "Server=DESKTOP-NM0ID5F\SQLEXPRESS;Database=Library_DB;User Id=sa;Password=123456;";
            string connStr = @"Server=DESKTOP-NM0ID5F\SQLEXPRESS;Database=Library_DB;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string query = String.Format("insert into Employees values ('{0}','{1}')",name,add);
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            //select

            conn.Open();
            query = "select * from Employees";
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                string n = reader.GetString(reader.GetOrdinal("Name"));
                string a = reader.GetString(reader.GetOrdinal("Id"));
                Console.WriteLine("{0}\t{1}",n,a);
                
            }
            conn.Close();


        }
    }
}
