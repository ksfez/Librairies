using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libraries
{
    public partial class AddLibrarian : System.Web.UI.Page
    {
        string fname, lname, salary, idLib, query;
        string ID;
        static OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        static OleDbCommand myOleDbCommand = myOleDbConnection.CreateCommand();
        OleDbDataReader myOleDbDataReader = null;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                fname = "";
                lname = "";
                salary = "";
                idLib = "";
                query = "select FIRSTNAME, LASTNAME, SALARY, IDLIB from LIBRARIAN where IDLIBRARIAN=" + TextBoxID.Text;
                myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = query;

                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(myOleDbDataReader);
                foreach (DataRow row in dt.Rows)
                {
                    ID = TextBoxID.Text;
                    fname = row["FIRSTNAME"].ToString();
                    lname = row["LASTNAME"].ToString();
                    salary = row["SALARY"].ToString();
                    idLib = row["IDLIB"].ToString();
                }
                if (lname == "")
                {
                    myOleDbConnection.Close();
                    query = "insert into Librarian values(" + TextBoxID.Text + ",'" + TextBoxFirstName.Text + "','" + TextBoxLastName.Text + "','" + TextBoxSalary.Text + "'," + TextBoxIDLib.Text + " )";
                    myOleDbCommand = myOleDbConnection.CreateCommand();
                    myOleDbCommand.CommandText = query;
                    myOleDbConnection.Open();
                    myOleDbDataReader = myOleDbCommand.ExecuteReader();
                    myOleDbConnection.Close();

                    query = "commit";
                    myOleDbCommand = myOleDbConnection.CreateCommand();
                    myOleDbCommand.CommandText = query;
                    myOleDbConnection.Open();
                    myOleDbDataReader = myOleDbCommand.ExecuteReader();
                    Page.RegisterStartupScript("UserMsg", "<script>alert('New librarian added successfuly');</script>");
                    myOleDbConnection.Close();
                }
                else
                {
                    throw new Exception();
                }
               

            }
            catch
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('Impossible to add this new librarian: this id already exist');</script>");
                
            }
             
            myOleDbConnection.Close();
        }

      
    }
}