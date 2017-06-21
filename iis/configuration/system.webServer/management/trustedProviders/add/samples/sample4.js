var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager"); 
adminManager.CommitPath = "MACHINE/WEBROOT"; 
adminManager.SetMetadata("pathMapper", "AdministrationConfig");

var trustedProvidersSection = adminManager.GetAdminSection("system.webServer/management/trustedProviders", "MACHINE/WEBROOT"); 
var trustedProvidersCollection = trustedProvidersSection.Collection;

var addElement = trustedProvidersCollection.CreateNewElement("add");
addElement.Properties.Item("type").Value = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
trustedProvidersCollection.AddElement(addElement);

adminManager.CommitChanges();