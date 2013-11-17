using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DrTreuhandWeb
{
      public class RouteConfig
        {
            public static void RegisterRoutes(RouteCollection routes)
            {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}",
                    defaults: new { controller = "DRTreuhand", action = "Index" }
                );
                routes.MapRoute(
                  name: "Unternehmer",
                  url: "{controller}/{action}",
                  defaults: new { controller = "DRTreuhand", action = "Unternehmer" }
              );
                routes.MapRoute(
                  name: "Leistungen",
                  url: "{controller}/{action}",
                  defaults: new { controller = "DRTreuhand", action = "Leistungen" }
              );
            }
        }
    }
