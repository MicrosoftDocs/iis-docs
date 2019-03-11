using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection applicationInitializationSection = config.GetSection("system.webServer/applicationInitialization", "Default Web Site");
            applicationInitializationSection["remapManagedRequestsTo"] = @"HelloJoe.htm";
            applicationInitializationSection["skipManagedModules"] = true;
            applicationInitializationSection["doAppInitAfterRestart"] = true;
            
            ConfigurationElementCollection applicationInitializationCollection = applicationInitializationSection.GetCollection();
            
            ConfigurationElement addElement = applicationInitializationCollection.CreateElement("add");
            addElement["initializationPage"] = @"JoesSite.htm";
            addElement["hostName"] = @"JoesHost";
            applicationInitializationCollection.Add(addElement);
            
            serverManager.CommitChanges();
        }
    }
}