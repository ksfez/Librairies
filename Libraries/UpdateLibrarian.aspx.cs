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
    public partial class UpdateLibrarian : System.Web.UI.Page
    {
        string query, query2;
        OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        OleDbCommand myOleDbCommand, myOleDbCommand2;
        OleDbDataReader myOleDbDataReader, myOleDbDataReader2;
        string fname, lname, salary, idlib;
        string IDLibrarian;
        DataTable dt, dt2;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            fname = "";
            lname = "";
            idlib = "";
            salary = "";
            IDLibrarian = "";
            query = "select idLibrarian from LIBRARIAN where idLibrarian=" + TextBoxID.Text;
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
                    IDLibrarian = row["IDLIBRARIAN"].ToString(); 
                }
                if (IDLibrarian == "")
                {
                    throw new Exception();
                }
                myOleDbConnection.Close();
            }
            catch (Exception)
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('There is no librarian with this id');</script>");
                myOleDbConnection.Close();
            }

            fname = "";
            lname = "";
            idlib = "";
            salary = "";
            IDLibrarian = "";
            query2 = "select idLib from LIBRARIAN where idLib=" + TextBoxIDlib.Text;
            myOleDbCommand2 = myOleDbConnection.CreateCommand();
            myOleDbCommand2.CommandText = query2;

            try
            {
                myOleDbConnection.Open();
                myOleDbDataReader2 = myOleDbCommand2.ExecuteReader();
                dt2 = new DataTable();
                dt2.Load(myOleDbDataReader2);
                foreach (DataRow row in dt2.Rows)
                {
                    idlib = row["IDLIB"].ToString();
                }
                if (idlib == "")
                {
                    throw new Exception();
                }
                myOleDbConnection.Close();
            }
            catch (Exception)
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('There is no library with this id');</script>");
                myOleDbConnection.Close();
            }

            
            try
            {
                query = "update Librarian set firstName='" + firstName.Text + "' , lastName='" + lastName.Text + "' , salary=" + textBoxSalary.Text + ", idlib =" + TextBoxIDlib.Text + " where idLibrarian=" + TextBoxID.Text;
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