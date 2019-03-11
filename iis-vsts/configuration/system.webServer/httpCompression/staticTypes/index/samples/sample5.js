var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var httpCompressionSection = adminManager.GetAdminSection("system.webServer/httpCompression", "MACHINE/WEBROOT/APPHOST");
var staticTypesCollection = httpCompressionSection.ChildElements.Item("staticTypes").Collection;

var addElement = staticTypesCollection.CreateNewElement("add");
addElement.Properties.Item("mimeType").Value = "application/msword";
addElement.Properties.Item("enabled").Value = true;
staticTypesCollection.AddElement(addElement);

var addElement1 = staticTypesCollection.CreateNewElement("add");
addElement1.Properties.Item("mimeType").Value = "application/vnd.ms-powerpoint";
addElement1.Properties.Item("enabled").Value = true;
staticTypesCollection.AddElement(addElement1);

var addElement2 = staticTypesCollection.CreateNewElement("add");
addElement2.Properties.Item("mimeType").Value = "application/vnd.ms-excel";
addElement2.Properties.Item("enabled").Value = true;
staticTypesCollection.AddElement(addElement2);

adminManager.CommitChanges();