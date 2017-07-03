var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var hiddenSegmentsCollection = requestFilteringSection.ChildElements.Item("hiddenSegments").Collection;

var addElement = hiddenSegmentsCollection.CreateNewElement("add");
addElement.Properties.Item("segment").Value = "bin";
hiddenSegmentsCollection.AddElement(addElement);

var addElement1 = hiddenSegmentsCollection.CreateNewElement("add");
addElement1.Properties.Item("segment").Value = "App_Code";
hiddenSegmentsCollection.AddElement(addElement1);

adminManager.CommitChanges();