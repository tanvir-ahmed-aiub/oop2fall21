
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Tables
{
    public class Employees
    {
        SqlConnection conn;
        public Employees() {
            string connStr = @"Server = DESKTOP-NM0ID5F\SQLEXPRESS; Database = Library_DB; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List<Employee> GetAllEmployess() {
            string query = "select * from Employees";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Employee> data = new List<Employee>();

            while (reader.Read()) {
                Employee emp = new Employee();
                emp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                emp.Name = reader.GetString(reader.GetOrdinal("Name"));
                emp.Address = reader.GetString(reader.GetOrdinal("Address"));
                emp.Username = reader.GetString(reader.GetOrdinal("Username"));
                emp.Password = reader.GetString(reader.GetOrdinal("Password"));
                data.Add(emp);
            }
            conn.Close();
            return data;
        }
        public Employee GetEmployee(int id) {
            string query = "select * from Employees where Id = " + id;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp = null;
            while (reader.Read())
            {
                emp = new Employee();
                emp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                emp.Name = reader.GetString(reader.GetOrdinal("Name"));
                emp.Address = reader.GetString(reader.GetOrdinal("Address"));
                emp.Username = reader.GetString(reader.GetOrdinal("Username"));
                emp.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return emp;
        }
        public bool Insert(Employee emp) {
            string query = String.Format("Insert into Employees values ('{0}','{1}','{2}','{3}')", emp.Name, emp.Address, emp.Username, emp.Password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
            
        }
        public bool CheckLogin(string username, string password) {
            string query = String.Format("select Name from Employees where Username='{0}' and Password='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
        public Employee Search(string uname)
        {
            string query = String.Format("select * from Employees where Username='{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp = null;
            while (reader.Read())
            {
                emp = new Employee();
                emp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                emp.Name = reader.GetString(reader.GetOrdinal("Name"));
                emp.Address = reader.GetString(reader.GetOrdinal("Address"));
                emp.Username = reader.GetString(reader.GetOrdinal("Username"));
                //emp.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return emp;

        }
        public bool Update(Employee emp)
        {
            string query = String.Format("Update Employees set Name='{0}' , Address='{1}' where Username='{2}'", emp.Name, emp.Address, emp.Username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
            
        }
        public bool Delete(string username)
        {
            string query = String.Format("delete from Employees where Username='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if(rs > 0) { return true; }
            return false;
        }
    }
}
