using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection webSocketSection = config.GetSection("system.webServer/webSocket", "Default Web Site");
            webSocketSection["enabled"] = true;
            webSocketSection["receiveBufferLimit"] = 4194304;
            webSocketSection["pingInterval"] = TimeSpan.Parse("00:00:10");
            
            serverManager.CommitChanges();
        }
    }
}