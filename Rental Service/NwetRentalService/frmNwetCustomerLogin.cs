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
    public partial class frmNwetCustomerLogin : Form
    {
        public frmNwetCustomerLogin()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();
            GlobalData._UserId = db.checkRegCustomer(txtUsername.Text, txtPassword.Text);
            if (GlobalData._UserId != 0)
            {
               
                MessageBox.Show("Login Success");
                GlobalData._Username = txtUsername.Text;
                frmNwetRentalForm rental = new frmNwetRentalForm();
                rental.Show();

            }
            else
                MessageBox.Show("Login Failure");
        }
    }
}
