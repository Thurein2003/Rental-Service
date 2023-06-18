/*
 * Created by SharpDevelop.
 * User: ohnma
 * Date: 02/01/2023
 * Time: 9:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentalService
{
	/// <summary>
	/// Description of frmAdminLogin.
	/// </summary>
	public partial class frmNwetAdminLogin : Form
	{
		public frmNwetAdminLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        

        void BtnLoginClick(object sender, EventArgs e)
		{
			
			Admin admin=new Admin();

			if (admin.Login(txtUserName.Text, txtPassword.Text) == true)
			{
				MessageBox.Show("Log in Success");
				
				frmItemCreation fic = new frmItemCreation();
				fic.Show();
			}
			else
				MessageBox.Show("Login Fail");
				
		}
	}
}
