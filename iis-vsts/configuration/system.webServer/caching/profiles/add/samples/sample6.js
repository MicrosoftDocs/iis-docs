var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var cachingSection = adminManager.GetAdminSection("system.webServer/caching", "MACHINE/WEBROOT/APPHOST");
var profilesCollection = cachingSection.ChildElements.Item("profiles").Collection;

var addElement = profilesCollection.CreateNewElement("add");
addElement.Properties.Item("extension").Value = "asp";
addElement.Properties.Item("policy").Value = "CacheUntilChange";
addElement.Properties.Item("kernelCachePolicy").Value = "CacheUntilChange";
profilesCollection.AddElement(addElement, 0);

adminManager.CommitChanges();