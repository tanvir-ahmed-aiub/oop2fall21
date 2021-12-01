using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DataAccess.Tables;

namespace DataAccess
{
    public class Database
    {
        public Books Books { get; set; }
        public Employees Employees { get; set; }

        public Database() {
            /*string connStr = @"Server = DESKTOP - NM0ID5F\SQLEXPRESS; Database = Library_DB; Integrated Security = true";";
            SqlConnection conn = new SqlConnection(connStr);
            Books = new Books(conn);*/
            Books = new Books();
            Employees = new Employees();

        }

        
    }
}
