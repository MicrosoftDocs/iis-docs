var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var authorizationSection = adminManager.GetAdminSection("system.ftpServer/security/authorization", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var authorizationCollection = authorizationSection.Collection;

var addElement = authorizationCollection.CreateNewElement("add");
addElement.Properties.Item("accessType").Value = "Allow";
addElement.Properties.Item("roles").Value = "administrators";
addElement.Properties.Item("permissions").Value = "Read, Write";
authorizationCollection.AddElement(addElement);

var addElement1 = authorizationCollection.CreateNewElement("add");
addElement1.Properties.Item("accessType").Value = "Deny";
addElement1.Properties.Item("users").Value = "guest";
addElement1.Properties.Item("permissions").Value = "Read, Write";
authorizationCollection.AddElement(addElement1);

adminManager.CommitChanges();