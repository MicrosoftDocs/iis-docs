var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var staticContentSection = adminManager.GetAdminSection("system.webServer/staticContent", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var staticContentCollection = staticContentSection.Collection;

var mimeMapElement = staticContentCollection.CreateNewElement("mimeMap");
mimeMapElement.Properties.Item("fileExtension").Value = "syx";
mimeMapElement.Properties.Item("mimeType").Value = "application/octet-stream";
staticContentCollection.AddElement(mimeMapElement);

var mimeMapElement1 = staticContentCollection.CreateNewElement("mimeMap");
mimeMapElement1.Properties.Item("fileExtension").Value = "tab";
mimeMapElement1.Properties.Item("mimeType").Value = "text/plain";
staticContentCollection.AddElement(mimeMapElement1);

adminManager.CommitChanges();