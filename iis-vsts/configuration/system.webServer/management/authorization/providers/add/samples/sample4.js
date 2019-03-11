var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager"); 
adminManager.CommitPath = "MACHINE/WEBROOT"; 
adminManager.SetMetadata("pathMapper", "AdministrationConfig");

var authorizationSection = adminManager.GetAdminSection("system.webServer/management/authorization", "MACHINE/WEBROOT"); 
var providersCollection = authorizationSection.ChildElements.Item("providers").Collection;

var addElement = providersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "ContosoAuthorizationProvider";
addElement.Properties.Item("type").Value = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
providersCollection.AddElement(addElement);
authorizationSection.Properties.Item("defaultProvider").Value = "ContosoAuthorizationProvider";

adminManager.CommitChanges();