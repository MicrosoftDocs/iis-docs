var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager"); 
adminManager.CommitPath = "MACHINE/WEBROOT"; 
adminManager.SetMetadata("pathMapper", "AdministrationConfig");

var authenticationSection = adminManager.GetAdminSection("system.webServer/management/authentication", "MACHINE/WEBROOT"); 
var providersCollection = authenticationSection.ChildElements.Item("providers").Collection;

var addElement = providersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "ContosoAuthenticationProvider";
addElement.Properties.Item("type").Value = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
providersCollection.AddElement(addElement);
authenticationSection.Properties.Item("defaultProvider").Value = "ContosoAuthenticationProvider";

adminManager.CommitChanges();