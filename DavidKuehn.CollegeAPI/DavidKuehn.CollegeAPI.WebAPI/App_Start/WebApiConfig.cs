using DavidKuehn.CollegeAPI.WebAPI.DependencyResolvers;
using System.Web.Http;

namespace DavidKuehn.CollegeAPI.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

            );

            // Configure our dependency resolver
            config.DependencyResolver = new AdhocDependencyResolver();

        }
    }
}
