using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Libraries
{
    public partial class UpdateMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUpdateReader_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateMyProfile.aspx");
        }

        protected void ButtonUpdateLibrarian_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateLibrarian.aspx");
        }
    }
}