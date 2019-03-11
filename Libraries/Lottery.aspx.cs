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
    public partial class Lottery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string IDToReturn = "";
            OleDbCommand myOleDbCommand;
            OleDbDataReader myOleDbDataReader;
            OleDbConnection myOleDbConnection = new OleDbConnection("provider=OraOLEDB.Oracle;DATA SOURCE=system;PERSIST SECURITY INFO=True;USER ID=SYSTEM;password=Jerusalem26");

            //MakeLotteryToLibraries
            myOleDbCommand = myOleDbConnection.CreateCommand();
            myOleDbCommand.CommandText = "MakeLotteryToLibraries";
            myOleDbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            OleDbParameter par1 = new OleDbParameter("RETURN_VALUE", OleDbType.Integer);
            par1.Direction = ParameterDirection.ReturnValue;
            par1.Size = 4000;

            myOleDbCommand.Parameters.Add(par1);
            try
            {
                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand.ExecuteReader();
                if (!myOleDbDataReader.HasRows)
                    IDToReturn = "There were no results for the SQL Query";
                DataTable dt = new DataTable();
                dt.Load(myOleDbDataReader);
                IDToReturn = " ";
                string m = (myOleDbCommand.Parameters["RETURN_VALUE"].Value).ToString();
                IDToReturn = m;
            }
            catch (Exception ex)
            {
                IDToReturn = "Error in function MakeLotteryToLibraries";

            }
            myOleDbConnection.Close();





            string StringToReturn = "";
            OleDbCommand myOleDbCommand2;
            myOleDbCommand2 = myOleDbConnection.CreateCommand();
            myOleDbCommand2.CommandText = "WinnerInfo";
            myOleDbCommand2.CommandType = CommandType.StoredProcedure;


            OleDbParameter par2 = new OleDbParameter("outString", OleDbType.VarChar);
            par1.Direction = ParameterDirection.Output;
            par1.Size = 4000;
            myOleDbCommand.Parameters.Add(par2);

            OleDbParameter par3 = new OleDbParameter("idd", OleDbType.Integer);
            par2.Direction = ParameterDirection.Input;
            par2.Value = int.Parse(IDToReturn);
            myOleDbCommand.Parameters.Add(par3);



            try
            {
                myOleDbConnection.Open();
                myOleDbDataReader = myOleDbCommand2.ExecuteReader();
                if (!myOleDbDataReader.HasRows)
                    StringToReturn = "No result";
                DataTable dt = new DataTable();
                dt.Load(myOleDbDataReader);
                StringToReturn = "";
                string m = (string)myOleDbCommand.Parameters["outString"].Value;
                StringToReturn = m;
                myOleDbConnection.Close();

                
                TextBoxWinner.Text = StringToReturn;

            }
            catch (Exception ex)
            {
                StringToReturn = "Error in Function";
            }





            /*
            //Winner Info
            myOleDbCommand2 = myOleDbConnection.CreateCommand();
            myOleDbCommand2.CommandText = "WinnerInfo";
            myOleDbCommand2.CommandType = System.Data.CommandType.StoredProcedure;

            OleDbParameter par2 = new OleDbParameter("OUTPUT_VALUE", OleDbType.VarChar);
            par2.Direction = ParameterDirection.Output;
            par2.Size = 4000;
            

            OleDbParameter par3 = new OleDbParameter("ID", OleDbType.Numeric);
            par3.Direction = ParameterDirection.Input;
            par3.Size = 38;
            par3.Value = int.Parse(StringToReturn);

            myOleDbCommand2.Parameters.Add(par3);
            myOleDbCommand2.Parameters.Add(par2);

            
            try
            {
                myOleDbConnection.Open();
                myOleDbCommand2.ExecuteNonQuery();
                string m2 = (myOleDbCommand.Parameters["OUTPUT_VALUE"].Value).ToString();
                StringToReturn2 = m2;
            }
            catch (Exception ex)
            {
                StringToReturn = "Error in function MakeLotteryToLibraries";
            }
                myOleDbConnection.Close();

            */

            /*
        string fname, lname, ID, age, query;
        OleDbCommand myOleDbCommand3=myOleDbConnection.CreateCommand();
        OleDbDataReader myOleDbDataReader3 = null;
        DataTable dt3;

            fname = "";
            lname = "";
            age = "";
            query = "select FIRSTNAME, LASTNAME, AGE from READERS where ID=" + int.Parse(IDToReturn);
            myOleDbCommand3 = myOleDbConnection.CreateCommand();
            myOleDbCommand3.CommandText = query;

            try
            {

                myOleDbConnection.Open();
                myOleDbDataReader3 = myOleDbCommand3.ExecuteReader();
                dt3 = new DataTable();
                dt3.Load(myOleDbDataReader3);
                foreach (DataRow row in dt3.Rows)
                {
                    ID = IDToReturn;
                    fname = row["FIRSTNAME"].ToString();
                    lname = row["LASTNAME"].ToString();
                    age = row["AGE"].ToString();
                }
                if (lname == "")
                {
                    throw new Exception();
                }
                else
                {
                    string winner;
                    winner = fname;
                    int j = 0;
                    for (j = 0; j < winner.Length && winner[j] == ' '; j++) ;
                    for (int i = j; i < winner.Length && winner[i] != ' '; i++)
                        TextBoxWinner.Text += winner[i];
                    TextBoxWinner.Text += " ";


                    winner = lname; 
                    j = 0;
                    for (j = 0; j < winner.Length && winner[j] == ' '; j++) ;
                    for (int i = j; i < winner.Length && winner[i] != ' '; i++)
                        TextBoxWinner.Text += winner[i];
                    TextBoxWinner.Text += ", ";


                    winner = age;
                    j = 0;
                    for (j = 0; j < winner.Length && winner[j] == ' '; j++) ;
                    for (int i = j; i < winner.Length && winner[i] != ' '; i++)
                        TextBoxWinner.Text += winner[i];
                    TextBoxWinner.Text += " years";
                                        
                }
                myOleDbConnection.Close();
            }
            catch (System.Exception ex)
            {
                myOleDbConnection.Close();
                Page.RegisterStartupScript("UserMsg", "<script>alert('There is no reader with this id');</script>");
            }
            */

        }


    }
}