using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace blog.Controllers
{
    public class ResourceController : Controller
    {
        private const string ResourceRoot = "~/Content";

        public static void MapRoutes(RouteCollection routes)
        {
            var cssDefaults = new { controller = "Resource", action = "Css", id = UrlParameter.Optional };
            var jsDefaults  = new { controller = "Resource", action = "Js", id = UrlParameter.Optional };

            routes.IgnoreRoute("*.js|css");
            routes.MapRoute("Resource Css", "{id}.css", cssDefaults, new { id = ".*" });
            routes.MapRoute("Resource Js", "{id}.js", jsDefaults);
        }

        public ActionResult Css(string id = null)
        {
            return ServeCombineableResource(id, "css", "text/css");
        }

        public ActionResult Js(string id = null)
        {
            return ServeCombineableResource(id, "js", "text/javascript");
        }

        public ActionResult ServeCombineableResource(string id, string extension, string mime)
        {
            var rootPath = Server.MapPath(ResourceRoot);
            var filePath = System.IO.Path.Combine(rootPath, id + "." + extension);
            if (System.IO.File.Exists(filePath))
                return File(filePath, mime);

            switch (id)
            {
                case "all":
                    if (System.IO.Directory.Exists(rootPath))
                    {
                        // get all files, pack in one and serve
                        foreach (var fileName in System.IO.Directory.GetFiles(rootPath, "*." + extension))
                        {
                            throw new NotImplementedException();
                        }
                    }
                    break;
            }

            return HttpNotFound();
        }
    }
}
