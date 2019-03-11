var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso";
var modulesSection = adminManager.GetAdminSection("system.webServer/modules", "MACHINE/WEBROOT/APPHOST/Contoso");
var modulesCollection = modulesSection.Collection;

var addElement = modulesCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "CartHeader";
addElement.Properties.Item("type").Value = "Contoso.ShoppingCart.Header";
addElement.Properties.Item("preCondition").Value = "managedHandler";
modulesCollection.AddElement(addElement);

adminManager.CommitChanges();