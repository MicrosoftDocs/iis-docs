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
         ConfigurationElement siteElement = FindElement(sitesCollection, "site", "name", @"Contoso");

         if (siteElement == null) throw new InvalidOperationException("Element not found!");

         ConfigurationElementCollection siteCollection = siteElement.GetCollection();
         ConfigurationElement applicationElement = siteCollection.CreateElement("application");

         applicationElement["path"] = @"/ShoppingCart";
         ConfigurationElementCollection applicationCollection = applicationElement.GetCollection();
         ConfigurationElement virtualDirectoryElement = applicationCollection.CreateElement("virtualDirectory");
         virtualDirectoryElement["path"] = @"/";
         virtualDirectoryElement["physicalPath"] = @"C:\Inetpub\Contoso\ShoppingCart";
         applicationCollection.Add(virtualDirectoryElement);
         siteCollection.Add(applicationElement);

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