using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration appHostConfig = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection fastCgiSection = appHostConfig.GetSection("system.webServer/fastCgi");
         ConfigurationElementCollection fastCgiCollection = fastCgiSection.GetCollection();
         ConfigurationElement applicationElement = fastCgiCollection.CreateElement("application");
         applicationElement["fullPath"] = @"c:\php\php-cgi.exe";
         fastCgiCollection.Add(applicationElement);

         Configuration webConfig = serverManager.GetWebConfiguration("Contoso");
         ConfigurationSection handlersSection = webConfig.GetSection("system.webServer/handlers");
         ConfigurationElementCollection handlersCollection = handlersSection.GetCollection();
         ConfigurationElement addElement = handlersCollection.CreateElement("add");
         addElement["name"] = @"PHP-FastCGI";
         addElement["path"] = @"*.php";
         addElement["verb"] = @"GET,HEAD,POST";
         addElement["modules"] = @"FastCgiModule";
         addElement["scriptProcessor"] = @"c:\php\php-cgi.exe";
         addElement["resourceType"] = @"Either";
         handlersCollection.AddAt(0, addElement);

         serverManager.CommitChanges();
      }
   }
}