var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var securityElement = ftpServerElement.ChildElements.Item("security");
var authenticationElement = securityElement.ChildElements.Item("authentication");
var customAuthenticationElement = authenticationElement.ChildElements.Item("customAuthentication");
var providersCollection = customAuthenticationElement.ChildElements.Item("providers").Collection;
var addElement1 = providersCollection.CreateNewElement("add");
   addElement1.Properties.Item("name").Value = "FtpCustomAuthenticationModule";
   addElement1.Properties.Item("enabled").Value = true;
   providersCollection.AddElement(addElement1);

adminManager.CommitChanges();