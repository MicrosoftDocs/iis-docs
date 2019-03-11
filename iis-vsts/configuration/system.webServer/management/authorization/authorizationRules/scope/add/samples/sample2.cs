using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetAdministrationConfiguration();
         ConfigurationSection authorizationSection = config.GetSection("system.webServer/management/authorization");
         ConfigurationElementCollection authorizationRulesCollection = authorizationSection.GetCollection("authorizationRules");

         ConfigurationElement scopeElement = FindElement(authorizationRulesCollection, "scope", "path", @"/Default Web Site");
         if (scopeElement == null)
         {
            scopeElement = authorizationRulesCollection.CreateElement("scope");
            scopeElement["path"] = @"/Default Web Site";
            authorizationRulesCollection.Add(scopeElement);
         }

         ConfigurationElementCollection scopeCollection = scopeElement.GetCollection();
         ConfigurationElement addElement = scopeCollection.CreateElement("add");
         addElement["name"] = @"ContosoUser";
         scopeCollection.Add(addElement);

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