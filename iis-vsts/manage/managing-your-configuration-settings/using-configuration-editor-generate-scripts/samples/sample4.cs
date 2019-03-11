using System;
using Microsoft.Web.Administration;
 
internal static class Sample {
  private static void Main() {
  ServerManager serverManager = new ServerManager();
Configuration config = serverManager.GetApplicationHostConfiguration();
 
ConfigurationSection applicationPoolsSection = config.GetSection("system.applicationHost/applicationPools");
 
ConfigurationElementCollection applicationPoolsCollection = applicationPoolsSection.GetCollection();
 
for (int i = 0; i < 10; i++) {
CreateApplicationPool(applicationPoolsCollection,
"AppPool" + i.ToString(),
  "AppPoolId" + i.ToString(),
"AppPoolPwd" + i.ToString());
}
serverManager.CommitChanges();
}
 
private static void CreateApplicationPool(ConfigurationSection applicationPoolsSection,
string appPoolName,
string appPoolUserName,
string appPoolPassword) 
{
  ConfigurationElement addElement = applicationPoolsCollection.CreateElement("add");
addElement["name"] = appPoolName;
 
ConfigurationElement processModelElement = addElement.ChildElements["processModel"];
processModelElement["identityType"] = @"SpecificUser";
processModelElement["userName"] = appPoolUserName;
processModelElement["password"] = appPoolPassword;
applicationPoolsCollection.Add(addElement);
}
}