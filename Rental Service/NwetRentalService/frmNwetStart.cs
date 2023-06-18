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
    public partial class frmNwetStart : Form
    {
        public frmNwetStart()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmNwetAdminLogin adm = new frmNwetAdminLogin();
            adm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmNwetRegistration reg = new frmNwetRegistration();
            reg.Show();
        }

        private void frmNickyStart_Load(object sender, EventArgs e)
        {

        }
    }
}
