using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pLevnon
{
    public partial class Logout2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //delete all user details
            Session.Abandon();
            Response.Redirect("Homepage.aspx");
            

        }
    }
}