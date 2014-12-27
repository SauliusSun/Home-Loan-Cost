﻿using System.Web.Mvc;
using System.Web.Routing;

namespace HomeLoanCost
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Clear();

            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}
