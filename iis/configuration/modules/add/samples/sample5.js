var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager"); 
adminManager.CommitPath = "MACHINE/WEBROOT"; 
adminManager.SetMetadata("pathMapper", "AdministrationConfig");
var modulesSection = adminManager.GetAdminSection("modules", "MACHINE/WEBROOT"); 

var modulesCollection = modulesSection.Collection;
var addElement = modulesCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "ContosoProvider";
modulesCollection.AddElement(addElement);

adminManager.CommitChanges();