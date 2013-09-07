using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication3
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var config = GlobalConfiguration.Configuration;
            config.EnableCors();            
            config.MapHttpAttributeRoutes();
            //RouteTable.Routes.MapHttpRoute(
            //  name: "DefaultApi",
            //  routeTemplate: "api/{controller}/{id}",
            //  defaults: new { id = System.Web.Http.RouteParameter.Optional }
            //  );
            //RouteTable.Routes.MapHttpRoute(
            //    name: "ApiByAction",
            //    routeTemplate: "api/{controller}/{id}/related",
            //    defaults: new { action = "Get" });

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}