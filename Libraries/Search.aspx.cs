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
    public partial class Search : System.Web.UI.Page
    {
        string query;
        string lib;
        int count; //length of the dataBase
        int j; //to compare to count
        OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        OleDbCommand myOleDbCommand;
        OleDbDataReader myOleDbDataReader;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxAvailable.Visible = false;
            TextBoxLibraries.Visible = false;
            Libraries.Visible = false;
            Available.Visible = false;
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            //query="select idbook, title, numOfCopy-numOfLendedCopies AS numOfAvailable from (select idbook, title, count(idCopyBook) AS numOfCopy from copyBook natural join books group by idbook, title) natural join  (select idbook, title, count(idCopyBook) AS numOfLendedCopies from copyBook natural join lending natural join books group by idbook, title) order by title asc";
            try
            {
                query = "select idbook, title, numOfCopy-numOfLendedCopies AS numOfAvailable, NAMELIB from (select idbook, title, count(idCopyBook) AS numOfCopy from copyBook natural join books group by idbook, title) natural join (select idbook, title, count(idCopyBook) AS numOfLendedCopies from copyBook natural join lending natural join books group by idbook, title) natural join belongsto natural join libraries where title=' " + TextBoxSearch.Text + "' order by title asc";
                myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = query;

                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(myOleDbDataReader);


                TextBoxAvailable.Text = "";
                TextBoxLibraries.Text = "";


                foreach (DataRow row in dt.Rows)
                    count++;
                foreach (DataRow row in dt.Rows)
                {
                    j++;
                    TextBoxAvailable.Text = row["numOfAvailable"].ToString();
                    lib = row["NameLib"].ToString();
                    for (int i = 0; i < lib.Length && lib[i] != ' '; i++)
                        TextBoxLibraries.Text += lib[i];
                    if (j != count)
                        TextBoxLibraries.Text += ", ";
                }


                if (TextBoxAvailable.Text == "" || TextBoxLibraries.Text == "")
                {
                    throw new Exception();
                }
                else
                {

                    Available.Visible = true;
                    Libraries.Visible = true;
                    TextBoxAvailable.Visible = true;
                    TextBoxLibraries.Visible = true;
                }
            }
            catch
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('Impossible to find this book');</script>");
        

            }

            myOleDbConnection.Close();


        }

        protected void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}