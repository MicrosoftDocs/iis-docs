using System;
using Microsoft.Web.Administration;

internal static class Sample {

private static void Main() {

ServerManager serverManager = new ServerManager();
Configuration config = serverManager.GetApplicationHostConfiguration();

ConfigurationSection applicationPoolsSection = config.GetSection("system.applicationHost/applicationPools");

ConfigurationElementCollection applicationPoolsCollection = applicationPoolsSection.GetCollection();

ConfigurationElement addElement = applicationPoolsCollection.CreateElement("add");
addElement["name"] = @"applicationPool1";

ConfigurationElement processModelElement = addElement.ChildElements["processModel"];
processModelElement["identityType"] = @"SpecificUser";
processModelElement["userName"] = @"PoolId1";
processModelElement["password"] = @"PoolId1Pwd";
applicationPoolsCollection.Add(addElement);

serverManager.CommitChanges();
}
}