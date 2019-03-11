using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libraries
{
    public partial class Librarian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddLibrarian.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteLibrarian.aspx");
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateLibrarian.aspx");
        }
    }
}