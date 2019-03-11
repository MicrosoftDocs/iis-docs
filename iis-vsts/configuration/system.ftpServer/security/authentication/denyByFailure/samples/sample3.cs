using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection authenticationSection = config.GetSection("system.ftpServer/security/authentication");
            
            ConfigurationElement denyByFailureElement = authenticationSection.GetChildElement("denyByFailure");
            denyByFailureElement["enabled"] = true;
            denyByFailureElement["maxFailure"] = 10;
            denyByFailureElement["entryExpiration"] = TimeSpan.Parse("00:00:35");
            denyByFailureElement["loggingOnlyMode"] = false;
            
            serverManager.CommitChanges();
        }
    }
}