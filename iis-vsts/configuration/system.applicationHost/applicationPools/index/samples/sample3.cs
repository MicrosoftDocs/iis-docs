using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

   private static void Main() {

      using(ServerManager serverManager = new ServerManager()) { 
      Configuration config = serverManager.GetApplicationHostConfiguration();

      ConfigurationSection applicationPoolsSection = config.GetSection("system.applicationHost/applicationPools");

      ConfigurationElementCollection applicationPoolsCollection = applicationPoolsSection.GetCollection();

      ConfigurationElement addElement = applicationPoolsCollection.CreateElement("add");
      addElement["name"] = @"Contoso";
      addElement["autoStart"] = true;
      addElement["managedPipelineMode"] = @"Integrated";
      applicationPoolsCollection.Add(addElement);

      serverManager.CommitChanges();
      }
   }
}