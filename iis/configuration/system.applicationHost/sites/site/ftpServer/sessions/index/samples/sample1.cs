using System;
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
         ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
         ConfigurationElementCollection sitesCollection = sitesSection.GetCollection();

         ConfigurationElement siteElement = FindElement(sitesCollection, "site", "name", @"ftp.example.com");
         if (siteElement == null) throw new InvalidOperationException("Element not found!");

         ConfigurationElement ftpServerElement = siteElement.GetChildElement("ftpServer");
         ConfigurationElementCollection sessionsElement = ftpServerElement.GetChildElement("sessions").GetCollection();

         Console.WriteLine(String.Format("Active Sessions: {0}", sessionsElement.Count));

         foreach (ConfigurationElement sessionElement in sessionsElement)
         {
            Console.WriteLine(String.Format("\tSession ID: {0}",
                sessionElement.Attributes["sessionId"].Value.ToString()));
            Console.WriteLine(String.Format("\t\tUser Name: {0}",
                sessionElement.Attributes["userName"].Value.ToString()));
            Console.WriteLine(String.Format("\t\tPrevious Command: {0}",
                sessionElement.Attributes["previousCommand"].Value.ToString()));
         }
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