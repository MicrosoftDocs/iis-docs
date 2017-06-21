var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var globalModulesSection = adminManager.GetAdminSection("system.webServer/globalModules", "MACHINE/WEBROOT/APPHOST");
var globalModulesCollection = globalModulesSection.Collection;

var addElement = globalModulesCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "ImageCopyrightModule";
addElement.Properties.Item("image").Value = "%windir%\\system32\\inetsrv\\imageCopyrightModule.dll";
globalModulesCollection.AddElement(addElement);

adminManager.CommitChanges();