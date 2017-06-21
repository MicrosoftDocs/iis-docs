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
            // Retrieve the sites collection.
            ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
            ConfigurationElementCollection sitesCollection = sitesSection.GetCollection();

            // Locate a specific site.
            ConfigurationElement siteElement = FindElement(sitesCollection, "site", "name", @"mySite");
            if (siteElement == null) throw new InvalidOperationException("Element not found!");

            // Create an object for the ftpServer element.
            ConfigurationElement ftpServerElement = siteElement.GetChildElement("ftpServer");
            // Create an instance of the FlushLog method.
            ConfigurationMethodInstance FlushLog = ftpServerElement.Methods["FlushLog"].CreateInstance();
            // Execute the method to flush the logs for the FTP site.
            FlushLog.Execute();
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