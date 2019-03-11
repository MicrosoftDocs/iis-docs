var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso";

var defaultDocumentSection = adminManager.GetAdminSection("system.webServer/defaultDocument",
   "MACHINE/WEBROOT/APPHOST/Contoso");

defaultDocumentSection.Properties.Item("enabled").Value = true;

var filesCollection = defaultDocumentSection.ChildElements.Item("files").Collection;

var addElement = filesCollection.CreateNewElement("add");
addElement.Properties.Item("value").Value = "home.html";
filesCollection.AddElement(addElement, 0);

adminManager.CommitChanges();