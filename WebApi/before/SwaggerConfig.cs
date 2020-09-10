using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "");
                //c.IncludeXmlComments(GetXmlCommentsPath());
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            })
            .EnableSwaggerUi(c =>
            {
                c.InjectJavaScript(Assembly.GetExecutingAssembly(), "WebApi/Swagger_lan.js");
            });
        }

        private static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\WebApi.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
