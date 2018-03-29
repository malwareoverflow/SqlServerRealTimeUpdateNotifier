using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SIGNALRDB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        string connString = @"Data Source=VAMPIRE\SQLEXPRESS;Initial Catalog=Notifications;Integrated Security=True";
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Start SqlDependency with application initialization
            SqlDependency.Start(connString);
        }
        protected void Application_End()
        {
            //Free the dependency
            SqlDependency.Stop(connString);
        }
    }
}
