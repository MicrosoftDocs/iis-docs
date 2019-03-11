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
         ConfigurationSection applicationPoolsSection = config.GetSection("system.applicationHost/applicationPools");
         ConfigurationElementCollection applicationPoolsCollection = applicationPoolsSection.GetCollection();
         ConfigurationElement addElement = FindElement(applicationPoolsCollection, "add", "name", @"DefaultAppPool");

         if (addElement == null) throw new InvalidOperationException("Element not found!");

         ConfigurationElement cpuElement = addElement.GetChildElement("cpu");
         cpuElement["action"] = @"KillW3wp";
         cpuElement["resetInterval"] = TimeSpan.Parse("00:04:00");

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