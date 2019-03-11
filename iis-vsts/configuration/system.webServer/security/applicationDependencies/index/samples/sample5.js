var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var applicationDependenciesSection = adminManager.GetAdminSection("system.webServer/security/applicationDependencies", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var applicationDependenciesCollection = applicationDependenciesSection.Collection;
var applicationElement = applicationDependenciesCollection.CreateNewElement("application");
applicationElement.Properties.Item("name").Value = "My Custom Application";
applicationElement.Properties.Item("groupId").Value = "MyCustomGroup";

var applicationCollection = applicationElement.Collection;
var addElement = applicationCollection.CreateNewElement("add");
addElement.Properties.Item("groupId").Value = "ASP";
applicationCollection.AddElement(addElement);
applicationDependenciesCollection.AddElement(applicationElement);

adminManager.CommitChanges();