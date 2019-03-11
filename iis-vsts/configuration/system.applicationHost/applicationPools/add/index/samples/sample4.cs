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
         ConfigurationElement addElement = applicationPoolsCollection.CreateElement("add");
         addElement["name"] = @"Contoso";
         ConfigurationElement recyclingElement = addElement.GetChildElement("recycling");
         ConfigurationElement periodicRestartElement = recyclingElement.GetChildElement("periodicRestart");
         ConfigurationElementCollection scheduleCollection = periodicRestartElement.GetCollection("schedule");
         ConfigurationElement addElement1 = scheduleCollection.CreateElement("add");
         addElement1["value"] = TimeSpan.Parse("03:00:00");
         scheduleCollection.Add(addElement1);
         applicationPoolsCollection.Add(addElement);
         serverManager.CommitChanges();
      }
   }
}