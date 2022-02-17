using System.Web.Http;
using System.Web.Http.Cors;

namespace Examen_KY
{
    public static class WebApiConfig
    {
        /// <summary>
        /// Registro de rutas de api
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Configuración CORS
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);

            // Configuración de rutas y servicios de API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
