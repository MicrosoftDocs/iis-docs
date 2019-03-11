var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager"); 
adminManager.CommitPath = "MACHINE/WEBROOT"; 
adminManager.SetMetadata("pathMapper", "AdministrationConfig");

var authenticationSection = adminManager.GetAdminSection("system.webServer/management/authentication", "MACHINE/WEBROOT"); 
var credentialsCollection = authenticationSection.ChildElements.Item("credentials").Collection;

var addElement = credentialsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "ContosoUser";
addElement.Properties.Item("password").Value = "P@ssw0rd";
addElement.Properties.Item("enabled").Value = true;
credentialsCollection.AddElement(addElement);

adminManager.CommitChanges();