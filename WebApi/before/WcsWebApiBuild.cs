using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebApi
{
    public class WcsWebApiBuild
    {
        public void Bulid()
        {
            string WcsApiServer = Properties.Resources.WcsApiServer;
            var config = new HttpSelfHostConfiguration(WcsApiServer);
            config.MapHttpAttributeRoutes();
            //config.Formatters.Add(new PlainTextTypeFormatter());
            config.Routes.MapHttpRoute(name: "DefaultApi",
                                               routeTemplate: "api/{controller}/{action}/{id}",
                                               defaults: new { id = RouteParameter.Optional });
            SwaggerConfig.Register(config);
            using (var sever = new HttpSelfHostServer(config))
            {
                sever.OpenAsync().Wait();
                while (true) { }
            }
        }
       
    }
}
