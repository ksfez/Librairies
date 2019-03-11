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
    public partial class Tables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query;
            OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
            OleDbCommand myOleDbCommand;
            OleDbDataReader myOleDbDataReader, myOleDbDataReader2, myOleDbDataReader3;
            DataTable dt, dt2, dt3;

            //Readers

            query = "select * from Readers ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);

            GridView1.Columns.Clear();

            GridView1.DataSource = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
            GridView1.Visible = true;
            myOleDbConnection.Close();

            //Lending

            query = "select * from Lending ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);


            GridView2.Columns.Clear();
            GridView2.DataSource = null;
            GridView2.DataSource = dt;
            GridView2.DataBind();
            GridView2.Visible = true;
            myOleDbConnection.Close();

            //CopyBook

            query = "select * from CopyBook ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);
            GridView3.Columns.Clear();

            GridView3.DataSource = null;
            GridView3.DataSource = dt;
            GridView3.DataBind();
            GridView3.Visible = true;
            myOleDbConnection.Close();

            //Books

            query = "select * from Books ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);
            GridView4.Columns.Clear();

            GridView4.DataSource = null;
            GridView4.DataSource = dt;
            GridView4.DataBind();
            GridView4.Visible = true;
            myOleDbConnection.Close();

            //BelongsTo

            query = "select * from BelongsTo ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);
            GridView5.Columns.Clear();

            GridView5.DataSource = null;
            GridView5.DataSource = dt;
            GridView5.DataBind();
            GridView5.Visible = true;
            myOleDbConnection.Close();

            //Libraries

            query = "select * from Libraries ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);
            GridView6.Columns.Clear();

            GridView6.DataSource = null;
            GridView6.DataSource = dt;
            GridView6.DataBind();
            GridView6.Visible = true;
            myOleDbConnection.Close();

            //Librarian

            query = "select * from Librarian ";
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query;

            myOleDbConnection.Open();
            myOleDbDataReader = myOleDbCommand.ExecuteReader();
            dt = new DataTable();
            dt.Load(myOleDbDataReader);
            GridView7.Columns.Clear();

            GridView7.DataSource = null;
            GridView7.DataSource = dt;
            GridView7.DataBind();
            GridView7.Visible = true;
            myOleDbConnection.Close();

        }
    }
}