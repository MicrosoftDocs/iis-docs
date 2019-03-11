var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var isapiCgiRestrictionSection = adminManager.GetAdminSection("system.webServer/security/isapiCgiRestriction", "MACHINE/WEBROOT/APPHOST");
var isapiCgiRestrictionCollection = isapiCgiRestrictionSection.Collection;

var addElement = isapiCgiRestrictionCollection.CreateNewElement("add");
addElement.Properties.Item("path").Value = "C:\\Inetpub\\www.contoso.com\\wwwroot\\isapi\\custom.dll";
addElement.Properties.Item("allowed").Value = true;
addElement.Properties.Item("groupId").Value = "ContosoGroup";
addElement.Properties.Item("description").Value = "Contoso Extension";
isapiCgiRestrictionCollection.AddElement(addElement);

adminManager.CommitChanges();