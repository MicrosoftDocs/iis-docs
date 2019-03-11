using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetWebConfiguration("Default Web Site");
         ConfigurationSection requestFilteringSection = config.GetSection("system.webServer/security/requestFiltering");
         ConfigurationElementCollection filteringRulesCollection = requestFilteringSection.GetCollection("filteringRules");

         ConfigurationElement filteringRuleElement = filteringRulesCollection.CreateElement("filteringRule");
         filteringRuleElement["name"] = @"Block Image Leeching";
         filteringRuleElement["scanUrl"] = false;
         filteringRuleElement["scanQueryString"] = false;
         filteringRuleElement["scanAllRaw"] = false;

         ConfigurationElementCollection scanHeadersCollection = filteringRuleElement.GetCollection("scanHeaders");
         ConfigurationElement addElement = scanHeadersCollection.CreateElement("add");
         addElement["requestHeader"] = @"User-agent";
         scanHeadersCollection.Add(addElement);

         ConfigurationElementCollection appliesToCollection = filteringRuleElement.GetCollection("appliesTo");
         ConfigurationElement addElement1 = appliesToCollection.CreateElement("add");
         addElement1["fileExtension"] = @".gif";
         appliesToCollection.Add(addElement1);
         ConfigurationElement addElement2 = appliesToCollection.CreateElement("add");
         addElement2["fileExtension"] = @".jpg";
         appliesToCollection.Add(addElement2);
         ConfigurationElement addElement3 = appliesToCollection.CreateElement("add");
         addElement3["fileExtension"] = @".png";
         appliesToCollection.Add(addElement3);

         ConfigurationElementCollection denyStringsCollection = filteringRuleElement.GetCollection("denyStrings");
         ConfigurationElement addElement4 = denyStringsCollection.CreateElement("add");
         addElement4["string"] = @"leech-bot";
         denyStringsCollection.Add(addElement4);

         filteringRulesCollection.Add(filteringRuleElement);
         serverManager.CommitChanges();
      }
   }
}