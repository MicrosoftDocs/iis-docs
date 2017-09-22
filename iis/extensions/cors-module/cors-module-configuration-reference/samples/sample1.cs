using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {

        using(ServerManager serverManager = new ServerManager()) {
            Configuration config = serverManager.GetWebConfiguration("contentSite");

            ConfigurationSection corsSection = config.GetSection("system.webServer/cors");
            corsSection["enabled"] = true;
            corsSection["failUnlistedOrigins"] = true;

            ConfigurationElementCollection corsCollection = corsSection.GetCollection();

            ConfigurationElement addElement = corsCollection.CreateElement("add");
            addElement["origin"] = @"*";
            corsCollection.Add(addElement);

            ConfigurationElement addElement1 = corsCollection.CreateElement("add");
            addElement1["origin"] = @"https://*.microsoft.com";
            addElement1["allowCredentials"] = true;
            addElement1["maxAge"] = 120;

            ConfigurationElement allowHeadersElement = addElement1.GetChildElement("allowHeaders");
            allowHeadersElement["allowAllRequestedHeaders"] = true;

            ConfigurationElementCollection allowHeadersCollection = allowHeadersElement.GetCollection();

            ConfigurationElement addElement2 = allowHeadersCollection.CreateElement("add");
            addElement2["header"] = @"header1";
            allowHeadersCollection.Add(addElement2);

            ConfigurationElement addElement3 = allowHeadersCollection.CreateElement("add");
            addElement3["header"] = @"header2";
            allowHeadersCollection.Add(addElement3);

            ConfigurationElementCollection allowMethodsCollection = addElement1.GetCollection("allowMethods");

            ConfigurationElement addElement4 = allowMethodsCollection.CreateElement("add");
            addElement4["method"] = @"DELETE";
            allowMethodsCollection.Add(addElement4);

            ConfigurationElementCollection exposeHeadersCollection = addElement1.GetCollection("exposeHeaders");

            ConfigurationElement addElement5 = exposeHeadersCollection.CreateElement("add");
            addElement5["header"] = @"header1";
            exposeHeadersCollection.Add(addElement5);

            ConfigurationElement addElement6 = exposeHeadersCollection.CreateElement("add");
            addElement6["header"] = @"header2";
            exposeHeadersCollection.Add(addElement6);
            corsCollection.Add(addElement1);

            ConfigurationElement addElement7 = corsCollection.CreateElement("add");
            addElement7["origin"] = @"http://*";
            addElement7["allowed"] = false;
            corsCollection.Add(addElement7);

            serverManager.CommitChanges();
        }
    }
}
