var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso";
var authorizationSection = adminManager.GetAdminSection("system.webServer/security/authorization", "MACHINE/WEBROOT/APPHOST/Contoso");
var authorizationCollection = authorizationSection.Collection;

var addElement = authorizationCollection.CreateNewElement("add");
addElement.Properties.Item("accessType").Value = "Allow";
addElement.Properties.Item("roles").Value = "administrators";
authorizationCollection.AddElement(addElement);

adminManager.CommitChanges();