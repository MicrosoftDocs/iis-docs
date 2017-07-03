var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var alwaysAllowedQueryStringsCollection = requestFilteringSection.ChildElements.Item("alwaysAllowedQueryStrings").Collection;
var addElement = alwaysAllowedQueryStringsCollection.CreateNewElement("add");
addElement.Properties.Item("queryString").Value = "allowed=sequence";
alwaysAllowedQueryStringsCollection.AddElement(addElement);

adminManager.CommitChanges();