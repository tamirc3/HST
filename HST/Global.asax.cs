using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HST.Models;

namespace HST
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AppManager appManager = new AppManager();
            appManager.InitDb();
        }
    }

    public class AppManager
    {
        public static DbManager DbManager;

        public void InitDb() { 
        
            DbManager = new DbManager();
        }
        public static readonly Dictionary<UserType,HttpCookie> CookiesDictionary = new Dictionary<UserType, HttpCookie>();
    }
}
