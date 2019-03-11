using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

   private static void Main() {

      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetApplicationHostConfiguration();

         ConfigurationSection applicationPoolsSection = config.GetSection("system.applicationHost/applicationPools");

         ConfigurationElement applicationPoolDefaultsElement = applicationPoolsSection.GetChildElement("applicationPoolDefaults");
         applicationPoolDefaultsElement["autoStart"] = true;
         applicationPoolDefaultsElement["managedRuntimeVersion"] = @"v2.0";
         applicationPoolDefaultsElement["managedPipelineMode"] = @"Integrated";

         serverManager.CommitChanges();
      }
   }
}