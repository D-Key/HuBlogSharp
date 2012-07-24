using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace blog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Controller-specific rules in order of being checked
            Controllers.ResourceController.MapRoutes(routes);
            // Default route should be defined and applied last
            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Blog", action = "Index", id = UrlParameter.Optional });
        }

        protected void Application_Start()
        {
            // Uncomment RegisterAllAreas() call if you use areas (Project dropdown menu > Add > Area)
            // AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}