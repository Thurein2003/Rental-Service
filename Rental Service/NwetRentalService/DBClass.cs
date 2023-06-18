using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace RentalService
{
    
    public class DBClass
    {
        OleDbCommand mycmd;
        OleDbDataReader myreader;
        OleDbConnection conn;
        String constr;
                              
        public DBClass() //constructor
        {
            constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\RentalDB.mdb";
            conn = new OleDbConnection();
            conn.ConnectionString = constr;
        }

        public void CreateAccount(Customer c)  //carry input from BCCustomer
        {

            int id = getMaxUserId("Customer");   //Get last user ID from DB
            string query = "INSERT INTO Customer VALUES " + "(" + id + ",'" + c.Name + "','" + c.Password + "','" + c.Email + "','" + c.Phone + "','" + c.Address + "')";

            conn.Open();
            mycmd = new OleDbCommand(query, conn);

            mycmd.ExecuteScalar();
            conn.Close();

        }
        private int getMaxUserId(string tablename)
        {
            mycmd = new OleDbCommand();
            mycmd.Connection = conn;
           
            int id = 0;
            string query = "Select MAX(id) from " + tablename;
            mycmd.CommandText = query;
            try
            {
                conn.Open();
                if (mycmd.ExecuteScalar() != DBNull.Value)
                    id = Convert.ToInt32(mycmd.ExecuteScalar().ToString());
                else id = 0;

                return id + 1;
            }
            catch (OleDbException oex) { throw oex; }
            finally
            {
                conn.Close();
            }
        }

        public int checkExistingCustomer(string inputUserName)
        {
            int id = 0;
            string query = "Select id from Customer where cname='" + inputUserName + "'";

            mycmd = new OleDbCommand();
            mycmd.Connection = conn;
            mycmd.CommandText = query;
            try
            {
               
                conn.Open();

                OleDbDataReader reader = mycmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader.GetValue(0).ToString());    //array position "0" value - "cid"
                }

            }
            catch (OleDbException oe) { }
            conn.Close();
            return id;
        }

        public int checkRegCustomer(string username, string password)
        {
            int id = 0;
            string query = "Select id from Customer where cname='" + username + "' and cpassword='" + password + "'";
            mycmd = new OleDbCommand();
            mycmd.Connection = conn;
            mycmd.CommandText = query;
            try
            {
                conn.Open();
                OleDbDataReader reader = mycmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader.GetValue(0).ToString());    //array position "0" value - "id"
                                                                        //string name = reader.GetValue(1).ToString();

                }


            }
            catch (OleDbException oe) { }
            conn.Close();
            return id;
        }

        
        public DataSet getTable(int catid)
        {
           
            string sql = "SELECT * FROM Item where catid=" + catid + "AND available='yes' Order by id ASC";
            OleDbConnection connection = new OleDbConnection(constr);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "item_table");
            connection.Close();
            return ds;

        }
        public List<string> getCatogries()
        {
            var items = new List<string>();
            items.Add("none");

            string query = "Select catname from Category order by catid ASC";
            mycmd = new OleDbCommand();
            mycmd.Connection = conn;
            mycmd.CommandText = query;
            try
                {
                    conn.Open();

                    OleDbDataReader myreader = mycmd.ExecuteReader();
                    items.Clear();

                    while (myreader.HasRows)
                    {
                      myreader.GetName(0);
                      while (myreader.Read())
                        {
                           

                            items.Add(Convert.ToString(myreader.GetValue(0).ToString()));
                        }

                        myreader.NextResult();
                    }
                }
                catch (OleDbException oex) { throw oex; }
                finally
                {
                    conn.Close();
                }

             return items; 
        }


    }
}
