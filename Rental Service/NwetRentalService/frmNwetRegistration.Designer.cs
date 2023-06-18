
namespace RentalService
{
    partial class frmNwetRegistration
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNwetRegistration));
        	this.label8 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtAddress = new System.Windows.Forms.TextBox();
        	this.txtPhone = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.btnRegister = new System.Windows.Forms.Button();
        	this.txtEmail = new System.Windows.Forms.TextBox();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.txtName = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnLogin = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label8
        	// 
        	this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.Location = new System.Drawing.Point(100, 277);
        	this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(67, 15);
        	this.label8.TabIndex = 27;
        	this.label8.Text = "Address";
        	// 
        	// label7
        	// 
        	this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.Location = new System.Drawing.Point(109, 232);
        	this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(66, 17);
        	this.label7.TabIndex = 26;
        	this.label7.Text = "Phone";
        	// 
        	// txtAddress
        	// 
        	this.txtAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtAddress.Location = new System.Drawing.Point(181, 275);
        	this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
        	this.txtAddress.MaxLength = 200;
        	this.txtAddress.Name = "txtAddress";
        	this.txtAddress.Size = new System.Drawing.Size(262, 23);
        	this.txtAddress.TabIndex = 23;
        	// 
        	// txtPhone
        	// 
        	this.txtPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtPhone.Location = new System.Drawing.Point(181, 232);
        	this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
        	this.txtPhone.MaxLength = 20;
        	this.txtPhone.Name = "txtPhone";
        	this.txtPhone.Size = new System.Drawing.Size(262, 23);
        	this.txtPhone.TabIndex = 22;
        	// 
        	// label4
        	// 
        	this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
        	this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.DeepPink;
        	this.label4.Location = new System.Drawing.Point(181, 30);
        	this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(261, 25);
        	this.label4.TabIndex = 24;
        	this.label4.Text = "New User Registration";
        	this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// btnRegister
        	// 
        	this.btnRegister.ForeColor = System.Drawing.Color.Blue;
        	this.btnRegister.Location = new System.Drawing.Point(96, 342);
        	this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
        	this.btnRegister.Name = "btnRegister";
        	this.btnRegister.Size = new System.Drawing.Size(90, 31);
        	this.btnRegister.TabIndex = 25;
        	this.btnRegister.Text = "Register";
        	this.btnRegister.UseVisualStyleBackColor = true;
        	this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        	// 
        	// txtEmail
        	// 
        	this.txtEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtEmail.Location = new System.Drawing.Point(181, 184);
        	this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
        	this.txtEmail.MaxLength = 50;
        	this.txtEmail.Name = "txtEmail";
        	this.txtEmail.Size = new System.Drawing.Size(262, 23);
        	this.txtEmail.TabIndex = 20;
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtPassword.Location = new System.Drawing.Point(181, 146);
        	this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
        	this.txtPassword.MaxLength = 50;
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.PasswordChar = '*';
        	this.txtPassword.Size = new System.Drawing.Size(262, 23);
        	this.txtPassword.TabIndex = 21;
        	// 
        	// txtName
        	// 
        	this.txtName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtName.Location = new System.Drawing.Point(181, 98);
        	this.txtName.Margin = new System.Windows.Forms.Padding(2);
        	this.txtName.MaxLength = 50;
        	this.txtName.Name = "txtName";
        	this.txtName.Size = new System.Drawing.Size(262, 23);
        	this.txtName.TabIndex = 19;
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(109, 187);
        	this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(58, 22);
        	this.label3.TabIndex = 18;
        	this.label3.Text = "Email";
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(93, 149);
        	this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(82, 14);
        	this.label2.TabIndex = 17;
        	this.label2.Text = "Password";
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(52, 100);
        	this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(118, 19);
        	this.label1.TabIndex = 16;
        	this.label1.Text = "Login Username";
        	this.label1.Click += new System.EventHandler(this.Label1Click);
        	// 
        	// btnLogin
        	// 
        	this.btnLogin.ForeColor = System.Drawing.Color.Blue;
        	this.btnLogin.Location = new System.Drawing.Point(402, 342);
        	this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
        	this.btnLogin.Name = "btnLogin";
        	this.btnLogin.Size = new System.Drawing.Size(90, 31);
        	this.btnLogin.TabIndex = 28;
        	this.btnLogin.Text = "Login";
        	this.btnLogin.UseVisualStyleBackColor = true;
        	this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        	// 
        	// frmNwetRegistration
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(582, 429);
        	this.Controls.Add(this.btnLogin);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.txtAddress);
        	this.Controls.Add(this.txtPhone);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.btnRegister);
        	this.Controls.Add(this.txtEmail);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.txtName);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Name = "frmNwetRegistration";
        	this.Text = "RegistrationForm";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}