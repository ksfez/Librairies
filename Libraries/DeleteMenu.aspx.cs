using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libraries
{
    public partial class DeleteMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDeleteReader_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteAnAccount.aspx");
        }

        protected void ButtonDeleteLibrarian_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteLibrarian.aspx");
        }
    }
}