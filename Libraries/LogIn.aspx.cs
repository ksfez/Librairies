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
    public partial class LogIn : System.Web.UI.Page
    {
        string fname, lname, ID, age, query;
        static OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        static  OleDbCommand myOleDbCommand=myOleDbConnection.CreateCommand();
        OleDbDataReader myOleDbDataReader = null;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            
            fname = "";
            lname = "";
            age = "";
            query = "select FIRSTNAME, LASTNAME, AGE from READERS where ID=" + IDin.Text ;
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            try
            {

                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(myOleDbDataReader);
                foreach (DataRow row in dt.Rows)
                {
                    ID = IDin.Text;
                    fname = row["FIRSTNAME"].ToString();
                    lname = row["LASTNAME"].ToString();
                    age = row["AGE"].ToString();
                }
                if (lname != "")
                {
                    Session["ID"] = ID;
                    Session["firstName"] = fname;
                    Session["lastName"] = lname;
                    Response.Redirect("listBook.aspx");
                }
               else
                {
                    throw new Exception();
                }
                myOleDbConnection.Close();
             }
             catch (System.Exception ex)
             {
                 myOleDbConnection.Close();
                 Page.RegisterStartupScript("UserMsg", "<script>alert('There is no reader with this id');</script>");
             }
        }

         protected void SignUp_Click(object sender, EventArgs e)
         {
             try
             {
                fname = "";
                lname = "";
                age = "";
                query = "select FIRSTNAME, LASTNAME, AGE from READERS where ID=" + IDup.Text ;
                myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = query;

                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(myOleDbDataReader);
                foreach (DataRow row in dt.Rows)
                {
                    ID = IDup.Text;
                    fname = row["FIRSTNAME"].ToString();
                    lname = row["LASTNAME"].ToString();
                    age = row["AGE"].ToString();
                }
                if (lname == "")
                {
                    myOleDbConnection.Close();
                    query = "insert into Readers values(" + IDup.Text + ",'" + firstName.Text + "','" + lastName.Text + "'," + textBoxAge.Text + " )";
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
                    Page.RegisterStartupScript("UserMsg", "<script>alert('New reader added successfuly');</script>");
                    myOleDbConnection.Close();   
                }
                else
                {
                   throw new Exception();
                }
                myOleDbConnection.Close();


                }
                catch
                {
                    Page.RegisterStartupScript("UserMsg", "<script>alert('Impossible to add this new reader: this id already exist');</script>");
                    myOleDbConnection.Close();
                }
         }         
    }
}