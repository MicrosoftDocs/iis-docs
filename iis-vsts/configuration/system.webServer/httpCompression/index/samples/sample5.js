var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var httpCompressionSection = adminManager.GetAdminSection("system.webServer/httpCompression", "MACHINE/WEBROOT/APPHOST");
var dynamicTypesCollection = httpCompressionSection.ChildElements.Item("dynamicTypes").Collection;

var addElement = dynamicTypesCollection.CreateNewElement("add");
addElement.Properties.Item("mimeType").Value = "application/msword";
addElement.Properties.Item("enabled").Value = true;
dynamicTypesCollection.AddElement(addElement);

var addElement1 = dynamicTypesCollection.CreateNewElement("add");
addElement1.Properties.Item("mimeType").Value = "application/vnd.ms-powerpoint";
addElement1.Properties.Item("enabled").Value = true;
dynamicTypesCollection.AddElement(addElement1);

var addElement2 = dynamicTypesCollection.CreateNewElement("add");
addElement2.Properties.Item("mimeType").Value = "application/vnd.ms-excel";
addElement2.Properties.Item("enabled").Value = true;
dynamicTypesCollection.AddElement(addElement2);

adminManager.CommitChanges();