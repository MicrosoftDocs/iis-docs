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

         ConfigurationSection odbcLoggingSection = config.GetSection("system.webServer/odbcLogging", "Default Web Site");
         odbcLoggingSection["dataSource"] = @"InternetDb";
         odbcLoggingSection["tableName"] = @"InternetLog";
         odbcLoggingSection["userName"] = @"InternetAdmin";
         odbcLoggingSection["password"] = @"P@ssw0rd";

         ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
         ConfigurationElementCollection sitesCollection = sitesSection.GetCollection();
         ConfigurationElement siteElement = FindElement(sitesCollection, "site", "name", @"Default Web Site");
         if (siteElement == null) throw new InvalidOperationException("Element not found!");

         ConfigurationElement logFileElement = siteElement.GetChildElement("logFile");
         logFileElement["customLogPluginClsid"] = @"{FF16065B-DE82-11CF-BC0A-00AA006111E0}";
         logFileElement["logFormat"] = @"Custom";

         serverManager.CommitChanges();
      }
   }

   private static ConfigurationElement FindElement(ConfigurationElementCollection collection, string elementTagName, params string[] keyValues)
   {
      foreach (ConfigurationElement element in collection)
      {
         if (String.Equals(element.ElementTagName, elementTagName, StringComparison.OrdinalIgnoreCase))
         {
            bool matches = true;
            for (int i = 0; i < keyValues.Length; i += 2)
            {
               object o = element.GetAttributeValue(keyValues[i]);
               string value = null;
               if (o != null)
               {
                  value = o.ToString();
               }
               if (!String.Equals(value, keyValues[i + 1], StringComparison.OrdinalIgnoreCase))
               {
                  matches = false;
                  break;
               }
            }
            if (matches)
            {
               return element;
            }
         }
      }
      return null;
   }
}