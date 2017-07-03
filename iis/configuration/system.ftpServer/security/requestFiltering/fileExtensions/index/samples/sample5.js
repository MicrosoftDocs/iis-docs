var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var fileExtensionsElement = requestFilteringSection.ChildElements.Item("fileExtensions");
var fileExtensionsCollection = fileExtensionsElement.Collection;

var addElement = fileExtensionsCollection.CreateNewElement("add");
addElement.Properties.Item("fileExtension").Value = ".exe";
addElement.Properties.Item("allowed").Value = false;
fileExtensionsCollection.AddElement(addElement);

var addElement1 = fileExtensionsCollection.CreateNewElement("add");
addElement1.Properties.Item("fileExtension").Value = ".com";
addElement1.Properties.Item("allowed").Value = false;
fileExtensionsCollection.AddElement(addElement1);

var addElement2 = fileExtensionsCollection.CreateNewElement("add");
addElement2.Properties.Item("fileExtension").Value = ".cmd";
addElement2.Properties.Item("allowed").Value = false;
fileExtensionsCollection.AddElement(addElement2);

var addElement3 = fileExtensionsCollection.CreateNewElement("add");
addElement3.Properties.Item("fileExtension").Value = ".bat";
addElement3.Properties.Item("allowed").Value = false;
fileExtensionsCollection.AddElement(addElement3);

adminManager.CommitChanges();