var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var verbsElement = requestFilteringSection.ChildElements.Item("verbs");
verbsElement.Properties.Item("applyToWebDAV").Value = false;
var verbsCollection = verbsElement.Collection;

var addElement = verbsCollection.CreateNewElement("add");
addElement.Properties.Item("verb").Value = "PUT";
addElement.Properties.Item("allowed").Value = false;
verbsCollection.AddElement(addElement);

adminManager.CommitChanges();