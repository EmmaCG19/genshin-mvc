using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GenshinMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Character-Details",
                url: "characters/{id}/details/{action}",
                defaults: new { controller = "CharacterDetails", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Characters-List",
                url: "characters",
                defaults: new { controller = "Character", action = "GetCharacters" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
