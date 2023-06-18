
namespace RentalService
{
    partial class frmNwetCustomerLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNwetCustomerLogin));
        	this.txtUsername = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.btnLogin = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// txtUsername
        	// 
        	this.txtUsername.Location = new System.Drawing.Point(216, 61);
        	this.txtUsername.Name = "txtUsername";
        	this.txtUsername.Size = new System.Drawing.Size(212, 20);
        	this.txtUsername.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(80, 64);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(55, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Username";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(83, 124);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(53, 13);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "Password";
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.Location = new System.Drawing.Point(216, 117);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.PasswordChar = '*';
        	this.txtPassword.Size = new System.Drawing.Size(215, 20);
        	this.txtPassword.TabIndex = 3;
        	// 
        	// btnLogin
        	// 
        	this.btnLogin.Location = new System.Drawing.Point(246, 173);
        	this.btnLogin.Name = "btnLogin";
        	this.btnLogin.Size = new System.Drawing.Size(143, 52);
        	this.btnLogin.TabIndex = 4;
        	this.btnLogin.Text = "Login";
        	this.btnLogin.UseVisualStyleBackColor = true;
        	this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        	// 
        	// frmNwetCustomerLogin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(590, 267);
        	this.Controls.Add(this.btnLogin);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.txtUsername);
        	this.Name = "frmNwetCustomerLogin";
        	this.Text = "frmCustomerLogin";
        	this.TopMost = true;
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}