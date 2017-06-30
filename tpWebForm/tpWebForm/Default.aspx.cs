using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text= Context.Items["msg"] as string;

            if (!Page.IsPostBack)
            {
                for(int i=0; i<3; i++)
                lstEntries.Items.Insert(0, string.Format("{0} valeur {1}", DateTime.Now.ToLongTimeString(),i));
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lstEntries.Items.Insert(0, string.Format("{0} page init ", DateTime.Now.ToLongTimeString()));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["nbRequetes"] = (int)Session["nbRequetes"]+1;
            //lstEntries.Items.Insert(0, string.Format("{0} page bouton ", DateTime.Now.ToLongTimeString()));
            Label3.Text = "nbr de requêtes envoyées au serveur = " + Session["nbRequetes"];//txtLogin.Text + " - " + txtPassword.Text;
            //lstEntries.Items.Add("Bienvenu " + txtLogin.Text + " password = " + txtPassword.Text);
        }

       
    }
}