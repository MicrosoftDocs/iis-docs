var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools",
   "MACHINE/WEBROOT/APPHOST");

var applicationPoolsCollection = applicationPoolsSection.Collection;

var addElement = applicationPoolsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "Contoso";
addElement.Properties.Item("autoStart").Value = true;
addElement.Properties.Item("managedPipelineMode").Value = "Integrated";
applicationPoolsCollection.AddElement(addElement);

adminManager.CommitChanges();