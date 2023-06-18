using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;//for Database Connection

namespace RentalService
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	
        
	
	public partial class frmItemCreation : Form
	{
		
		int id;
		int catid;
		
        double fees; //one month hire fees
        String itemName;
        String description;
        string avilable;
        String constr;
        
        
        OleDbCommand mycmd;
        OleDbDataReader myreader;
        OleDbConnection conn;
        
        int iRowIndex;
        DataTable table;
        OleDbDataAdapter dataadapter;
        
		public frmItemCreation()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

       

        void MainFormLoad(object sender, EventArgs e)
		{
			
               constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath+ @"\RentalDB.mdb"; 
                              
               conn = new OleDbConnection();
               conn.ConnectionString = constr;
               
               string query="SELECT * FROM item order by id ASC"; //SQL Query
			         
                 
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(query,conn);
                table = new DataTable("ItemTable");
               
                conn.Open();
                dataadapter.Fill(table);
                conn.Close();
                
                dataGridView1.DataSource=table;
           
		}
		
				
		void BtnExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnNewClick(object sender, EventArgs e)
		{
			txtName.Text="";
			txtFees.Text="";
			txtDescription.Text="";
			
			
			
            ShowGridView();
		}
		
		void ShowGridView()
		{
			
			    string query="SELECT * FROM item order by id ASC;";
			
                conn = new OleDbConnection (constr);
             
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(query,conn);
                table = new DataTable("ItemTable");
                conn.Open();
                dataadapter.Fill(table);
                conn.Close();
                dataGridView1.DataSource=table;
			
		}
		
		void BindObject()
		{
			
		
			itemName=txtName.Text;
			description=txtDescription.Text;
			avilable="yes";
			fees= double.Parse(txtFees.Text);
			
			
			
		}
		
		void BtnInsertClick(object sender, EventArgs e)
		{
			
			
			catid= cboAppliances.SelectedIndex+1;
			
			
			BindObject();
			
			if (txtFees.Text=="" || txtName.Text==""|| txtDescription.Text=="")
                {
                    MessageBox.Show("Plese Enter All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
			
	        id = 0;
           
         	string query = "Select MAX(Id) from Item";
            mycmd = new OleDbCommand (query, conn);

            try
            {
                conn.Open();
                if (mycmd.ExecuteScalar() != DBNull.Value)
                    id = Convert.ToInt32(mycmd.ExecuteScalar().ToString());
                else id = 0;

                
            }
            catch (OleDbException  oex) { throw oex; }
            finally
            {
                conn.Close();
            }
			
            id=id+1;
            
            lblID.Text="ID= "+ id.ToString();  
					
			
			try{
				
				   query= "INSERT INTO item values("+id+ ","+ catid + ",'"+itemName+"',"+fees+",'"+ description+"','"+ avilable +"')";
 			
                   conn = new OleDbConnection (constr);
                   conn.Open();
                   mycmd=new OleDbCommand(query,conn);
                   mycmd.ExecuteScalar();
                   

                  lblMessage.Text = " Record Saved! ";
			}catch(Exception ee){conn.Close(); };
			
			conn.Close();
	    	
			
		}
		
		void BtnDeleteClick(object sender, System.EventArgs e)
		{
			try{
				
				int rid=iRowIndex + 1;
				
				 if (this.table.Rows.Count==this.iRowIndex) return;
                     DialogResult dr=MessageBox.Show("Are you sure you want to delete this row ? ", "Confirm deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);	
		            if (dr ==DialogResult.Yes) //if 
		              {	
				
				
				         string query= "DELETE FROM item WHERE id=" + rid;
 			 
                          conn = new OleDbConnection (constr);
                         conn.Open();
                        mycmd=new OleDbCommand(query,conn);
                       mycmd.ExecuteNonQuery();
                   

                          lblMessage.Text = " Record Deleted! ";
		            }
			}catch(Exception ee){conn.Close(); };
			
			conn.Close();
	    	
		}
		
		void BtnUpdateClick(object sender, System.EventArgs e)
		{
			BindObject();
			
			try{
				
				int rid=iRowIndex + 1;
				
				 if (this.table.Rows.Count==this.iRowIndex) return;
                     DialogResult dr=MessageBox.Show("Are you sure you want to update this row ? ", "Confirm deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);	
		            if (dr ==DialogResult.Yes) //if 
		              {	
				
				
				         string query= "UPDATE item SET id=" + rid + ", catid="+ catid + ", name='" + itemName + "', fees="+ fees+", description='"+ description+"' WHERE id=" + rid;
 			 
                          conn = new OleDbConnection (constr);
                          conn.Open();
                          mycmd=new OleDbCommand(query,conn);
                          mycmd.ExecuteNonQuery();
                   

                          lblMessage.Text = " Record Updated! ";
		            }
			}catch(Exception ee){conn.Close(); };
			
			conn.Close();
			
			ShowGridView();
		}
   
 
  void DataGridView1Click(object sender, EventArgs e)
		{
			iRowIndex = dataGridView1.CurrentRow.Index;
			//lblID.Text="Record ID="+(iRowIndex+1).ToString();
			databind();
		}
  
  void databind()
  {              
  	               int id=iRowIndex+1;
  	
  	               string query= "SELECT * FROM item WHERE id=" + id;
                   conn = new OleDbConnection (constr);
                   conn.Open();
                   mycmd=new OleDbCommand(query,conn);
                   OleDbDataReader myreader;
                   myreader=mycmd.ExecuteReader();
                   while(myreader.Read())
                   {
                   	
                   	string cid=myreader.GetValue(1).ToString();
                   	if(cid=="1")
                         	{ 
                              cboAppliances.SelectedIndex=0;
                              catid=1;
                         	}
                   	else 
                   	{
                   		cboAppliances.SelectedIndex=1; 
                   		catid=2;
                   	}
                   
                   	
                   	txtName.Text = myreader.GetValue(2).ToString();
                   	txtFees.Text=myreader.GetValue(3).ToString();
                   	txtDescription.Text=myreader.GetValue(4).ToString();
                   	
                   
                   	
                   }
                   myreader.Close();
                   conn.Close();
     
   	
  }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
