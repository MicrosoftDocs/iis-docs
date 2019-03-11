var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST");
var applicationPoolsCollection = applicationPoolsSection.Collection;

var addElement = applicationPoolsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "Contoso";
var recyclingElement = addElement.ChildElements.Item("recycling");
var periodicRestartElement = recyclingElement.ChildElements.Item("periodicRestart");
var scheduleCollection = periodicRestartElement.ChildElements.Item("schedule").Collection;
var addElement1 = scheduleCollection.CreateNewElement("add");
addElement1.Properties.Item("value").Value = "03:00:00";
scheduleCollection.AddElement(addElement1);
applicationPoolsCollection.AddElement(addElement);

adminManager.CommitChanges();