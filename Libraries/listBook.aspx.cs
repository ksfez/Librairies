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
    public partial class listBook : System.Web.UI.Page
    {
        string query1, query2,query3;
        OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");
        OleDbCommand myOleDbCommand, myOleDbCommand2, myOleDbCommand3;
        OleDbDataReader myOleDbDataReader, myOleDbDataReader2, myOleDbDataReader3;
        DataTable dt,dt2,dt3;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            string firstName = (string) Session["firstName"];
            string lastName = (string)Session["lastName"];
            TextBoxFirstName.Text = firstName;
            TextBoxLastName.Text = lastName;

            //show all the lended books
            string ID = (string)Session["ID"];
            query1 = "select title, \"author\" from Books B natural join CopyBook C natural join Lending L where L.id="+ ID;
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = query1;

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

            //show the favorite author
            query2 = "select \"author\" from (select max(numOfBooks) AS numOfBooks, id   from (select count (\"author\") AS numOfBooks, \"author\" ,id from Books B natural join Lending L natural join copyBook C group by \"author\",id) group by id) natural join (select count (\"author\") AS numOfBooks, \"author\" ,id from Books B2 natural join Lending L2 natural join copyBook C2 group by \"author\",id) where id=" + ID;
            myOleDbCommand2 = myOleDbConnection.CreateCommand();
            myOleDbCommand2.CommandText = query2;
            myOleDbConnection.Open();
            myOleDbDataReader2 = myOleDbCommand2.ExecuteReader();
            dt2 = new DataTable();
            dt2.Load(myOleDbDataReader2);
            foreach (DataRow row in dt2.Rows)
            {
                TextBoxAuthor.Text = row["author"].ToString();
            }
            myOleDbConnection.Close();

            //show the penalty
            query3 = "select Sum((DateOfDay-ReturnDate)*penaltyPerDay) AS Penalty from readers natural join books natural join lending natural join copyBook where ID="+ID+ " AND dateOfDay>ReturnDate group by id, firstName, LastName UNION select 0 AS Penalty from readers natural join books natural join lending natural join copyBook where ID="+ ID+ " group by id, firstName, LastName having Sum((DateOfDay-ReturnDate)*penaltyPerDay)<0";

            myOleDbCommand3 = myOleDbConnection.CreateCommand();
            myOleDbCommand3.CommandText = query3;
            myOleDbConnection.Open();
            myOleDbDataReader3 = myOleDbCommand3.ExecuteReader();
            dt3 = new DataTable();
            dt3.Load(myOleDbDataReader3);
            foreach (DataRow row in dt3.Rows)
            {
                TextBoxPenalty.Text = row["penalty"].ToString();
            }
            
        }

        protected void TextBoxAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBoxPenalty_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}