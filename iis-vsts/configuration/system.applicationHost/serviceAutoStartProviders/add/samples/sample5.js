var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var serviceAutoStartProvidersSection = adminManager.GetAdminSection("system.applicationHost/serviceAutoStartProviders", "MACHINE/WEBROOT/APPHOST");
var serviceAutoStartProvidersCollection = serviceAutoStartProvidersSection.Collection;

var addElement = serviceAutoStartProvidersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "MyAutostartProvider";
addElement.Properties.Item("type").Value = "MyAutostartProvider, MyAutostartProvider, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
serviceAutoStartProvidersCollection.AddElement(addElement);

adminManager.CommitChanges();