using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Database db = new Database();
            //
            //List<Employee> data = db.Employees.GetAllEmployess();
            //List<Book> data = db.Books.Get();
            //dtPerson.DataSource = data;
            //dtPerson.DataSource
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
            
        }

        private void LoginClick(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string pass = tbPass.Text;
            Database db = new Database();
            try {
                bool rs = db.Employees.CheckLogin(uname, pass);
                if (rs == true)
                {
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Usename password");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenRegisterForm(object sender, EventArgs e)
        {
            //this.Hide();
            Registration rform = new Registration();
            rform.StartPosition = FormStartPosition.CenterScreen;
            rform.Show();
        }
    }
}
