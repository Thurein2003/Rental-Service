
namespace RentalService
{
    partial class frmNwetadminchoice
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNwetadminchoice));
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.Location = new System.Drawing.Point(267, 113);
        	this.button1.Margin = new System.Windows.Forms.Padding(2);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(118, 36);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Add Items";
        	this.button1.UseVisualStyleBackColor = true;
        	// 
        	// button2
        	// 
        	this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button2.Location = new System.Drawing.Point(475, 113);
        	this.button2.Margin = new System.Windows.Forms.Padding(2);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(127, 35);
        	this.button2.TabIndex = 1;
        	this.button2.Text = "View Customers Record";
        	this.button2.UseVisualStyleBackColor = true;
        	// 
        	// frmNwetadminchoice
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Bisque;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.ClientSize = new System.Drawing.Size(964, 266);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.Name = "frmNwetadminchoice";
        	this.Text = "frmadminchoice";
        	this.Load += new System.EventHandler(this.frmadminchoice_Load);
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}