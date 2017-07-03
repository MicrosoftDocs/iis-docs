using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetApplicationHostConfiguration();

         ConfigurationSection fastCgiSection = config.GetSection("system.webServer/fastCgi");
         ConfigurationElementCollection fastCgiCollection = fastCgiSection.GetCollection();
         ConfigurationElement applicationElement = fastCgiCollection.CreateElement("application");
         applicationElement["fullPath"] = @"C:\PHP\php-cgi.exe";
         applicationElement["arguments"] = @"";
         applicationElement["maxInstances"] = 4;
         applicationElement["idleTimeout"] = 300;
         applicationElement["activityTimeout"] = 30;
         applicationElement["requestTimeout"] = 90;
         applicationElement["instanceMaxRequests"] = 10000;
         applicationElement["protocol"] = @"NamedPipe";
         applicationElement["flushNamedPipe"] = false;

         ConfigurationElementCollection environmentVariablesCollection = applicationElement.GetCollection("environmentVariables");
         ConfigurationElement environmentVariableElement = environmentVariablesCollection.CreateElement("environmentVariable");
         environmentVariableElement["name"] = @"PHP_FCGI_MAX_REQUESTS";
         environmentVariableElement["value"] = @"10000";
         environmentVariablesCollection.Add(environmentVariableElement);
         fastCgiCollection.Add(applicationElement);

         ConfigurationSection handlersSection = config.GetSection("system.webServer/handlers");
         ConfigurationElementCollection handlersCollection = handlersSection.GetCollection();
         ConfigurationElement addElement = handlersCollection.CreateElement("add");
         addElement["name"] = @"PHP-FastCGI";
         addElement["path"] = @"*.php";
         addElement["verb"] = @"GET,HEAD,POST";
         addElement["modules"] = @"FastCgiModule";
         addElement["scriptProcessor"] = @"C:\PHP\php-cgi.exe";
         addElement["resourceType"] = @"Either";
         addElement["requireAccess"] = @"Script";
         handlersCollection.AddAt(0, addElement);

         serverManager.CommitChanges();
      }
   }
}