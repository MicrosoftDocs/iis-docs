using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace IIS_MOD_REQDATA
{
    public class IIS_MOD_REQDATA : IHttpModule
    {
        public void Init(HttpApplication application)
        {
            application.EndRequest += (new EventHandler(this.Application_EndRequest));
        }

        private void Application_EndRequest(Object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;

            // start writing out the request data

            context.Response.Write("<hr>");
            context.Response.Write("<b><font size=2 color=green>REQUEST HEADERS</font></b><br>");
            context.Response.Write("<font size=2>");
            context.Response.Write("METHOD : " + context.Request.HttpMethod + "<br>");
            context.Response.Write("URL : " + context.Request.Url + "<br>");
            context.Response.Write("QUERYSTRING : " + context.Request.QueryString + "<br>");
            context.Response.Write("</font><br>");

            // now response data

            context.Response.Write("<b><font size=2 color=blue>RESPONSE HEADERS</font></b><br>");
            context.Response.Write("<font size=2>");
            context.Response.Write("STATUS CODE : " + context.Response.StatusCode.ToString() + "." + context.Response.SubStatusCode.ToString() + "<br>");
            context.Response.Write("CONTENT TYPE : " + context.Response.ContentType.ToString() + "<br>");
            context.Response.Write("EXPIRES : " + context.Response.Expires.ToString() + "<br>");
            context.Response.Write("</font><br>");

            // set cache policy on response so it's not cached.

            context.Response.DisableKernelCache();
        }

        public void Dispose()
        {
        }
    }
}