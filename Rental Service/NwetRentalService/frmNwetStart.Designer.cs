
namespace RentalService
{
    partial class frmNwetStart
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
        	this.btnAdmin = new System.Windows.Forms.Button();
        	this.btnCustomer = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// btnAdmin
        	// 
        	this.btnAdmin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnAdmin.Location = new System.Drawing.Point(140, 110);
        	this.btnAdmin.Name = "btnAdmin";
        	this.btnAdmin.Size = new System.Drawing.Size(166, 77);
        	this.btnAdmin.TabIndex = 0;
        	this.btnAdmin.Text = "Admin";
        	this.btnAdmin.UseVisualStyleBackColor = true;
        	this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
        	// 
        	// btnCustomer
        	// 
        	this.btnCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnCustomer.Location = new System.Drawing.Point(458, 112);
        	this.btnCustomer.Name = "btnCustomer";
        	this.btnCustomer.Size = new System.Drawing.Size(146, 74);
        	this.btnCustomer.TabIndex = 1;
        	this.btnCustomer.Text = "Customer";
        	this.btnCustomer.UseVisualStyleBackColor = true;
        	this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
        	// 
        	// frmNwetStart
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Khaki;
        	this.ClientSize = new System.Drawing.Size(878, 313);
        	this.Controls.Add(this.btnCustomer);
        	this.Controls.Add(this.btnAdmin);
        	this.Name = "frmNwetStart";
        	this.Text = "frmStart";
        	this.Load += new System.EventHandler(this.frmNickyStart_Load);
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCustomer;
    }
}