var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");

var bindingsCollection = siteDefaultsElement.ChildElements.Item("bindings").Collection;
var bindingElement = bindingsCollection.CreateNewElement("binding");
bindingElement.Properties.Item("protocol").Value = "http";
bindingElement.Properties.Item("bindingInformation").Value = "127.0.0.1:8080:";
bindingsCollection.AddElement(bindingElement);

adminManager.CommitChanges();