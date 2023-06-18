
namespace RentalService
{
	partial class frmItemCreation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnExit = new System.Windows.Forms.Button();
			this.cboAppliances = new System.Windows.Forms.ComboBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFees = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnNew = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.rdoYes = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoNo = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblMessage = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(1031, 389);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 32);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// cboAppliances
			// 
			this.cboAppliances.FormattingEnabled = true;
			this.cboAppliances.Items.AddRange(new object[] {
									"Monitor",
									"TV",
									"Oven",
									"Smart coffee maker",
									"Projector"});
			this.cboAppliances.Location = new System.Drawing.Point(25, 43);
			this.cboAppliances.Name = "cboAppliances";
			this.cboAppliances.Size = new System.Drawing.Size(196, 21);
			this.cboAppliances.TabIndex = 11;
			this.cboAppliances.Text = "Monitor";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(26, 99);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(259, 20);
			this.txtName.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 21);
			this.label1.TabIndex = 13;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Description";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(25, 219);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(396, 129);
			this.txtDescription.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 28);
			this.label3.TabIndex = 16;
			this.label3.Text = "Choose One Type";
			// 
			// txtFees
			// 
			this.txtFees.Location = new System.Drawing.Point(26, 156);
			this.txtFees.Name = "txtFees";
			this.txtFees.Size = new System.Drawing.Size(251, 20);
			this.txtFees.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(25, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 19);
			this.label4.TabIndex = 18;
			this.label4.Text = "Monthly Fees";
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(33, 381);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(106, 38);
			this.btnNew.TabIndex = 19;
			this.btnNew.Text = "Refresh";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.BtnNewClick);
			// 
			// lblID
			// 
			this.lblID.Location = new System.Drawing.Point(167, 7);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(118, 20);
			this.lblID.TabIndex = 20;
			this.lblID.Text = "ID=";
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(160, 381);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(104, 40);
			this.btnInsert.TabIndex = 21;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsertClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(287, 381);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(99, 39);
			this.btnUpdate.TabIndex = 22;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(408, 383);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(108, 36);
			this.btnDelete.TabIndex = 23;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// rdoYes
			// 
			this.rdoYes.Checked = true;
			this.rdoYes.Location = new System.Drawing.Point(16, 24);
			this.rdoYes.Name = "rdoYes";
			this.rdoYes.Size = new System.Drawing.Size(79, 37);
			this.rdoYes.TabIndex = 26;
			this.rdoYes.TabStop = true;
			this.rdoYes.Text = "Yes";
			this.rdoYes.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoNo);
			this.groupBox1.Controls.Add(this.rdoYes);
			this.groupBox1.Location = new System.Drawing.Point(339, 92);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 84);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Available";
			// 
			// rdoNo
			// 
			this.rdoNo.Location = new System.Drawing.Point(77, 28);
			this.rdoNo.Name = "rdoNo";
			this.rdoNo.Size = new System.Drawing.Size(54, 29);
			this.rdoNo.TabIndex = 27;
			this.rdoNo.Text = "No";
			this.rdoNo.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(524, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(570, 316);
			this.dataGridView1.TabIndex = 28;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.Click += new System.EventHandler(this.DataGridView1Click);
			// 
			// lblMessage
			// 
			this.lblMessage.Location = new System.Drawing.Point(339, 7);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(179, 32);
			this.lblMessage.TabIndex = 29;
			this.lblMessage.Text = "Status=";
			// 
			// frmItemCreation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 431);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFees);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cboAppliances);
			this.Controls.Add(this.btnExit);
			this.Name = "frmItemCreation";
			this.Text = "Rental Service Admin";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cboAppliances;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFees;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.RadioButton rdoYes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoNo;
		
		
		
		
		
		
		
		
	}
}
