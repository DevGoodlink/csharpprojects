using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace tpWebForm
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code qui s’exécute au démarrage de l’application
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Application_Error(object sender, EventArgs e)
        {

        }
        void Application_Request(object sender, EventArgs e)
        {

        }
        void Session_Start(object sender, EventArgs e)
        {
            //Compteur de requêtes
            Session["nbRequetes"] = 0;

        }
        void Session_End(object sender, EventArgs e)
        {
           /*Inutile
            * Session["nbRequetes"] = 0;
            * */
        }
    }
}