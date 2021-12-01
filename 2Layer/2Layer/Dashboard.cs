
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entities;

namespace _2Layer
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Database db = new Database();
            try
            {
                dtEmployees.DataSource = db.Employees.GetAllEmployess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void SearchUser(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            Database db = new Database();
            Employee emp = db.Employees.Search(uname);
            if(emp == null)
            {
                MessageBox.Show("Employee not found");
                tbName.Text = "";
                tbAddress.Text = "";
            }
            else
            {
                tbName.Text = emp.Name;
                tbAddress.Text = emp.Address;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updatedName = tbName.Text;
            string updatedAddress = tbAddress.Text;
            Employee emp = new Employee();

            emp.Username = tbUname.Text;
            emp.Name = tbName.Text;
            emp.Address = tbAddress.Text;

            Database db = new Database();
            bool rs = db.Employees.Update(emp);
            if (rs)
            {
                dtEmployees.DataSource = db.Employees.GetAllEmployess();
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Failed to update");
            }

        }

        private void Delete(object sender, EventArgs e)
        {
            string username = tbUname.Text;
            Database db = new Database();
            bool rs = db.Employees.Delete(username);
            if (rs)
            {
                dtEmployees.DataSource = db.Employees.GetAllEmployess();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }
    }
}
