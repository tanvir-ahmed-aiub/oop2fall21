using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess.Tables
{
    public class Books
    {

        SqlConnection conn;

        public Books() {
            string connStr = @"Server = DESKTOP - NM0ID5F\SQLEXPRESS; Database = Library_DB; Integrated Security = true"; 
            conn = new SqlConnection(connStr);
        }

        public void Insert() {
            string query = "insert into ";
        }
        public void Update() { }
        public void Delete() { }
        public void Get() {
            string query = "select * from Emplye";
        }
        public void Search() { }
    }
}
