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
    public partial class DeleteAnAccount : System.Web.UI.Page
    {

        string query;
        OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        OleDbCommand myOleDbCommand;
        OleDbDataReader myOleDbDataReader;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from READERS where ID=" + TextBoxDelete.Text;
                myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = query;
                myOleDbCommand = myOleDbConnection.CreateCommand();
                myOleDbCommand.CommandText = query;
                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                dt = new DataTable();
                dt.Load(myOleDbDataReader);
                Page.RegisterStartupScript("UserMsg", "<script>alert('This reader has been deleted successfully');</script>");
            }
            catch (System.Exception ex)
            {
                myOleDbConnection.Close();
                Page.RegisterStartupScript("UserMsg", "<script>alert('Impossble to delete this reader');</script>");
            }
           
            
        }
    }
}