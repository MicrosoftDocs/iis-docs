using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetWebConfiguration("Default Web Site");

         ConfigurationSection httpRedirectSection = config.GetSection("system.webServer/httpRedirect");
         httpRedirectSection["enabled"] = true;
         httpRedirectSection["exactDestination"] = true;
         httpRedirectSection["httpResponseStatus"] = @"Found";

         ConfigurationElementCollection httpRedirectCollection = httpRedirectSection.GetCollection();
         ConfigurationElement addElement = httpRedirectCollection.CreateElement("add");
         addElement["wildcard"] = @"*.asp";
         addElement["destination"] = @"/default.htm";
         httpRedirectCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}