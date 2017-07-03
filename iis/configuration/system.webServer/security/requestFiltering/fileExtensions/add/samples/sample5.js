var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var fileExtensionsElement = requestFilteringSection.ChildElements.Item("fileExtensions");
fileExtensionsElement.Properties.Item("applyToWebDAV").Value = false;
var fileExtensionsCollection = fileExtensionsElement.Collection;

var addElement = fileExtensionsCollection.CreateNewElement("add");
addElement.Properties.Item("fileExtension").Value = "inc";
addElement.Properties.Item("allowed").Value = false;
fileExtensionsCollection.AddElement(addElement);

adminManager.CommitChanges();