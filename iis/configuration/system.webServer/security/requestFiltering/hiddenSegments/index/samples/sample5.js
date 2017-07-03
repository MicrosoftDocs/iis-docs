var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var hiddenSegmentsElement = requestFilteringSection.ChildElements.Item("hiddenSegments");
hiddenSegmentsElement.Properties.Item("applyToWebDAV").Value = false;

var hiddenSegmentsCollection = hiddenSegmentsElement.Collection;

var addElement = hiddenSegmentsCollection.CreateNewElement("add");
addElement.Properties.Item("segment").Value = "_private";
hiddenSegmentsCollection.AddElement(addElement);

adminManager.CommitChanges();