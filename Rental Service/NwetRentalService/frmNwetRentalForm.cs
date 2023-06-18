using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace RentalService
{
    public partial class frmNwetRentalForm : Form
    {
        int iRowIndex;
        List<int> item_ids = new List<int>();
        //Item item = new Item();
        int item_id = 0;
        string item_name = "";
        double item_price = 0.0;
        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\RentalDB.mdb";
        int nmonth;
        int uid;
        DateTime date1, date2;

        public frmNwetRentalForm()
        {
            InitializeComponent();
        }

        private void frmRentalForm_Load(object sender, EventArgs e)
        {
            DBClass db = new DBClass();
            List<string> lst = new List<string>();
            lst= db.getCatogries();
            lstAppliances.DataSource = lst;
            lstAppliances.Show();
            lblUserName.Text += GlobalData._Username;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            
            //frmReview fr = new frmReview();
            //fr.Show();
            this.Close();
        }

      

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            iRowIndex = dataGridView1.CurrentRow.Index;
           
            databind();
        }
        void databind()
        {
            int id = iRowIndex;
            string iname = dataGridView1[2,id].Value.ToString();
            int cid = lstAppliances.SelectedIndex + 1;

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = constr;
            string query = "SELECT * FROM item WHERE name='" + iname+ "' AND catid="+ cid;
            conn = new OleDbConnection(constr);
            conn.Open();
            OleDbCommand mycmd = new OleDbCommand(query, conn);
            OleDbDataReader myreader;
            myreader = mycmd.ExecuteReader();
            
            while (myreader.Read())
            {
                item_id = int.Parse(myreader.GetValue(0).ToString());
                item_name = myreader.GetValue(2).ToString();
                item_price = double.Parse(myreader.GetValue(3).ToString());
                    
            }
                       
            lstItemName.Items.Add(item_name);
          //  item.ItemName = item_name;
            lstPrice.Items.Add(item_price);
            item_ids.Add(item_id);
          //  items.Add(item);
          //  items.Select(e => e.ItemName).Distinct();
          //  lstItemName.DataSource = items;


            myreader.Close();
            conn.Close();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i=lstItemName.SelectedIndex;
            lstItemName.Items.RemoveAt(i);
            lstPrice.Items.RemoveAt(i);
            item_ids.RemoveAt(i);
        }

     
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double amount = 0.0;
           
            uid= GlobalData._UserId;
            
             date1 = dateTimePicker1.Value.Date;
             date2 = dateTimePicker2.Value.Date;
             nmonth = ((date2.Year - date1.Year) * 12) + date2.Month - date1.Month;
            if (nmonth != 0)
            {
                rtbOrderInfo.Text = "Customer Id=" + GlobalData._UserId;
                rtbOrderInfo.Text += "Customer Name=" + GlobalData._Username +"\n";
                rtbOrderInfo.Text += "Rental Date=" + date1.ToShortDateString() +"\n";

                rtbOrderInfo.Text += "Return Date=" + date2.ToShortDateString() +"\n";
                rtbOrderInfo.Text += "Number of Months=" + nmonth.ToString() + "\n" ;
                rtbOrderInfo.Text += "Total Amount=";

                foreach (var item in lstPrice.Items)
                {
                    amount += double.Parse(item.ToString());
                }
                amount = amount * nmonth;
                rtbOrderInfo.Text += amount.ToString();
            }
            else
            {
                MessageBox.Show("Please choose dates");
            }
        }

        private void lstAppliances_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DBClass db = new DBClass();
            dataGridView1.DataSource = db.getTable(lstAppliances.SelectedIndex + 1);
            dataGridView1.DataMember = "Item_table";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to order?", "Confirmation!", MessageBoxButtons.OKCancel);


            if (result == DialogResult.OK)
            {

                try
                {


                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = constr;
                    conn = new OleDbConnection(constr);
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    int i = 0;
                    foreach (var item in lstPrice.Items)
                    {

                        cmd.CommandText = "INSERT INTO Rent(cid,itemid,sdate,rdate) VALUES(" + uid + "," + item_ids[i] + ",'" + date1 + "','" + date2 + "')";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "UPDATE item SET available='no' WHERE id=" + item_ids[i];
                        cmd.ExecuteNonQuery();
                        i++;

                    }

                    conn.Close();
                }
                catch (Exception ee) { MessageBox.Show("Rental process failure"); }
                MessageBox.Show("Rental process Successful!");
                this.Close();

            }
        }
    }
}
