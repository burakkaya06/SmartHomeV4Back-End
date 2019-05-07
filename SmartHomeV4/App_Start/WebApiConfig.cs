using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SmartHomeV4
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // Web API routes
            config.MapHttpAttributeRoutes();

           // config.Routes.MapHttpRoute(
           //    name: "gettApi",
           //    routeTemplate: "api/{controller}/{action}/{kullaniciAdi}",
           //    defaults: new { kullaniciAdi = RouteParameter.Optional }
           //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           
        }
    }
}
