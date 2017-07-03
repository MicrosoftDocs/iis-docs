using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetWebConfiguration("Contoso");
            
            ConfigurationSection defaultDocumentSection = config.GetSection("system.webServer/defaultDocument");
            
            defaultDocumentSection["enabled"] = true;
            
            ConfigurationElementCollection filesCollection = defaultDocumentSection.GetCollection("files");
            ConfigurationElement addElement = filesCollection.CreateElement("add");
            addElement["value"] = @"home.html";
            filesCollection.AddAt(0, addElement);
            
            serverManager.CommitChanges();
        }
    }
}