
namespace RentalService
{
    partial class frmNwetRentalForm
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
        	this.lstAppliances = new System.Windows.Forms.ListBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.lblUserName = new System.Windows.Forms.Label();
        	this.btnRentalOrder = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.btnRemove = new System.Windows.Forms.Button();
        	this.rtbOrderInfo = new System.Windows.Forms.RichTextBox();
        	this.lstItemName = new System.Windows.Forms.ListBox();
        	this.lstPrice = new System.Windows.Forms.ListBox();
        	this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        	this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.btnConfirmOrder = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lstAppliances
        	// 
        	this.lstAppliances.FormattingEnabled = true;
        	this.lstAppliances.Location = new System.Drawing.Point(14, 36);
        	this.lstAppliances.Name = "lstAppliances";
        	this.lstAppliances.Size = new System.Drawing.Size(237, 82);
        	this.lstAppliances.TabIndex = 0;
        	this.lstAppliances.SelectedIndexChanged += new System.EventHandler(this.lstAppliances_SelectedIndexChanged_1);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(15, 20);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(108, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Choose an Appliance";
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Location = new System.Drawing.Point(15, 135);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(686, 158);
        	this.dataGridView1.TabIndex = 2;
        	this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        	this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
        	// 
        	// lblUserName
        	// 
        	this.lblUserName.AutoSize = true;
        	this.lblUserName.Location = new System.Drawing.Point(584, 9);
        	this.lblUserName.Name = "lblUserName";
        	this.lblUserName.Size = new System.Drawing.Size(66, 13);
        	this.lblUserName.TabIndex = 4;
        	this.lblUserName.Text = "User Name=";
        	// 
        	// btnRentalOrder
        	// 
        	this.btnRentalOrder.Location = new System.Drawing.Point(28, 486);
        	this.btnRentalOrder.Name = "btnRentalOrder";
        	this.btnRentalOrder.Size = new System.Drawing.Size(92, 51);
        	this.btnRentalOrder.TabIndex = 5;
        	this.btnRentalOrder.Text = "Place Order";
        	this.btnRentalOrder.UseVisualStyleBackColor = true;
        	this.btnRentalOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(584, 486);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(116, 43);
        	this.button1.TabIndex = 7;
        	this.button1.Text = "Exit";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// btnRemove
        	// 
        	this.btnRemove.Location = new System.Drawing.Point(15, 324);
        	this.btnRemove.Name = "btnRemove";
        	this.btnRemove.Size = new System.Drawing.Size(75, 30);
        	this.btnRemove.TabIndex = 9;
        	this.btnRemove.Text = "Remove";
        	this.btnRemove.UseVisualStyleBackColor = true;
        	this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
        	// 
        	// rtbOrderInfo
        	// 
        	this.rtbOrderInfo.Location = new System.Drawing.Point(298, 312);
        	this.rtbOrderInfo.Name = "rtbOrderInfo";
        	this.rtbOrderInfo.Size = new System.Drawing.Size(402, 147);
        	this.rtbOrderInfo.TabIndex = 10;
        	this.rtbOrderInfo.Text = "";
        	// 
        	// lstItemName
        	// 
        	this.lstItemName.FormattingEnabled = true;
        	this.lstItemName.Location = new System.Drawing.Point(96, 312);
        	this.lstItemName.Name = "lstItemName";
        	this.lstItemName.Size = new System.Drawing.Size(88, 147);
        	this.lstItemName.TabIndex = 11;
        	// 
        	// lstPrice
        	// 
        	this.lstPrice.FormattingEnabled = true;
        	this.lstPrice.Location = new System.Drawing.Point(181, 312);
        	this.lstPrice.Name = "lstPrice";
        	this.lstPrice.Size = new System.Drawing.Size(61, 147);
        	this.lstPrice.TabIndex = 12;
        	// 
        	// dateTimePicker1
        	// 
        	this.dateTimePicker1.Location = new System.Drawing.Point(289, 35);
        	this.dateTimePicker1.Name = "dateTimePicker1";
        	this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
        	this.dateTimePicker1.TabIndex = 13;
        	// 
        	// dateTimePicker2
        	// 
        	this.dateTimePicker2.Location = new System.Drawing.Point(286, 97);
        	this.dateTimePicker2.Name = "dateTimePicker2";
        	this.dateTimePicker2.Size = new System.Drawing.Size(234, 20);
        	this.dateTimePicker2.TabIndex = 14;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(288, 9);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(55, 13);
        	this.label2.TabIndex = 15;
        	this.label2.Text = "Start Date";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(289, 69);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(65, 13);
        	this.label3.TabIndex = 16;
        	this.label3.Text = "Return Date";
        	// 
        	// btnConfirmOrder
        	// 
        	this.btnConfirmOrder.Location = new System.Drawing.Point(159, 486);
        	this.btnConfirmOrder.Name = "btnConfirmOrder";
        	this.btnConfirmOrder.Size = new System.Drawing.Size(92, 51);
        	this.btnConfirmOrder.TabIndex = 17;
        	this.btnConfirmOrder.Text = "Confirm Order";
        	this.btnConfirmOrder.UseVisualStyleBackColor = true;
        	this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
        	// 
        	// frmNwetRentalForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        	this.ClientSize = new System.Drawing.Size(899, 549);
        	this.Controls.Add(this.btnConfirmOrder);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.dateTimePicker2);
        	this.Controls.Add(this.dateTimePicker1);
        	this.Controls.Add(this.lstPrice);
        	this.Controls.Add(this.lstItemName);
        	this.Controls.Add(this.rtbOrderInfo);
        	this.Controls.Add(this.btnRemove);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.btnRentalOrder);
        	this.Controls.Add(this.lblUserName);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.lstAppliances);
        	this.Name = "frmNwetRentalForm";
        	this.Text = "frmRentalForm";
        	this.Load += new System.EventHandler(this.frmRentalForm_Load);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstAppliances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnRentalOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RichTextBox rtbOrderInfo;
        private System.Windows.Forms.ListBox lstItemName;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmOrder;
    }
}