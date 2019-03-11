var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var securityElement = ftpServerElement.ChildElements.Item("security");
var commandFilteringElement = securityElement.ChildElements.Item("commandFiltering");
var commandFilteringCollection = commandFilteringElement.Collection;
var addElement = commandFilteringCollection.CreateNewElement("add");
   addElement.Properties.Item("command").Value = "SYST";
   addElement.Properties.Item("allowed").Value = false;
   commandFilteringCollection.AddElement(addElement);

adminManager.CommitChanges();