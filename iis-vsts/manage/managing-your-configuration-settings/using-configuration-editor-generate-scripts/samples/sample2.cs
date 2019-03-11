var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST");

var applicationPoolsCollection = applicationPoolsSection.Collection;

var addElement = applicationPoolsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "applicationPool1";
var processModelElement = addElement.ChildElements.Item("processModel");
processModelElement.Properties.Item("identityType").Value = "SpecificUser";
processModelElement.Properties.Item("userName").Value = "PoolId1";
processModelElement.Properties.Item("password").Value = "PoolId1Pwd";
applicationPoolsCollection.AddElement(addElement);

adminManager.CommitChanges();