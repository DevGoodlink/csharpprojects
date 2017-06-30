using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpWebForm
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetour_Click(object sender, EventArgs e)
        {
            Context.Items["msg"] = "Message de page1.aspx vers default";
            Server.Transfer("Default.aspx", true);
        }
    }
}