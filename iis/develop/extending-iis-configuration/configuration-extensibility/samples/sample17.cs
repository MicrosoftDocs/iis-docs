using System;
using System.Web;
using System.Web.Hosting;
using System.IO;
using Microsoft.Web.Administration;

namespace ConfigurationExtensibility
{
    public class SimpleLoggingModule : IHttpModule
    {
        private string GetlogfileDirectory(HttpContext context)
        {
            ConfigurationSection section = WebConfigurationManager.GetSection(
                    context, "system.webServer/simpleLogging");
            return (string)section["logfileDirectory"];
        }
 
        public void Init(HttpApplication context)
        {
            context.LogRequest += new EventHandler(LogRequest_EventHandler);
        }
 
        private void LogRequest_EventHandler(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            LogRequest(application.Context);
        }
 
        private void LogRequest(HttpContext context)
        {
            string logfileDirectory = GetlogfileDirectory(context);
 
            if (Directory.Exists(logfileDirectory) == false)
            {
                Directory.CreateDirectory(logfileDirectory);
            }
 
            string logfile = Path.Combine(logfileDirectory, DateTime.Now.ToString("yyyyMMdd") + ".log");
            string ogline = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
                    DateTime.Now,
                    context.Request.HttpMethod,
                    context.Request.UserHostAddress,
                    context.Request.Url.ToString(),
                    context.Request.ServerVariables["LOGON_USER"],
                    context.Request.UserAgent,
                    context.Response.StatusCode,
                    HostingEnvironment.SiteName);
        File.AppendAllText(logfile, ogline + Environment.NewLine);
        }
 
        public void Dispose()
        {
        }    
    }
}