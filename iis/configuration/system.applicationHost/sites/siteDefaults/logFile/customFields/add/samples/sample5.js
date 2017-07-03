var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var logFileElement = siteDefaultsElement.ChildElements.Item("logFile");
var customFieldsElement = logFileElement.ChildElements.Item("customFields");

var customFieldsCollection = customFieldsElement.Collection;

var addElement = customFieldsCollection.CreateNewElement("add");
addElement.Properties.Item("logFieldName").Value = "ContosoField";
addElement.Properties.Item("sourceName").Value = "ContosoSource";
addElement.Properties.Item("sourceType").Value = "ServerVariable";
customFieldsCollection.AddElement(addElement);

adminManager.CommitChanges();