using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalService
{
    public partial class frmNwetRegistration : Form
    {
        public frmNwetRegistration()
        {
            InitializeComponent();
        }

      
     

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Name = txtName.Text;
            c.Password = txtPassword.Text;
            c.Phone = txtPhone.Text;
            c.Email = txtEmail.Text;


            DBClass dbc = new DBClass();
            if (dbc.checkExistingCustomer(c.Name) == 0)
            {
                dbc.CreateAccount(c);
                MessageBox.Show("Registration Successful");
            }
            else
                MessageBox.Show("Customer name already exist");



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmNwetCustomerLogin fcl = new frmNwetCustomerLogin();
            fcl.Show();
        }
        
        void Label1Click(object sender, EventArgs e)
        {
        	
        }
    }
}
