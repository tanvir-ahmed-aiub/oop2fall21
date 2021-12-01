using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entities;
using DataAccess;

namespace _2Layer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var usename = tbUsername.Text;
            var address = tbAddress.Text;
            var password = tbPassword.Text;
            Employee emp = new Employee();
            emp.Name = name;
            emp.Address = address;
            emp.Username = usename;
            emp.Password = password;
            Database db = new Database();
            var r = db.Employees.Insert(emp);
            if (r)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            
        }

        private void LoginClick(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
