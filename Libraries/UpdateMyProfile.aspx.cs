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
    public partial class UpdateMyProfile : System.Web.UI.Page
    {
        string query;
        OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        OleDbCommand myOleDbCommand;
        OleDbDataReader myOleDbDataReader;
        string fname, lname, age;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            fname = "";
            lname = "";
            age = "";
            query = "select FIRSTNAME, LASTNAME, AGE from READERS where ID=" + TextBoxID.Text;
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
                    ID = TextBoxID.Text;
                    fname = row["FIRSTNAME"].ToString();
                    lname = row["LASTNAME"].ToString();
                    age = row["AGE"].ToString();
                }
                if (lname == "")
                {
                    throw new Exception();
                }
                myOleDbConnection.Close();
            }
            catch (Exception)
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('There is no reader with this id');</script>");
                myOleDbConnection.Close();
            }

            try
            {
                query = "update Readers set firstName='" + firstName.Text + "' ,lastName='" + lastName.Text + "' ,age=" + textBoxAge.Text + "where ID=" + TextBoxID.Text;
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
                Page.RegisterStartupScript("UserMsg", "<script>alert('Your profile has been updated successfuly');</script>");
                myOleDbConnection.Close();

            }
            catch
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('Impossible to update your profile: this ID doesn't exist');</script>");
                myOleDbConnection.Close();
            }
        }

    }
}
