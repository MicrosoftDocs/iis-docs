var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var fileSystemElement = authoringSection.ChildElements.Item("fileSystem");
fileSystemElement.Properties.Item("allowHiddenFiles").Value = true;
fileSystemElement.Properties.Item("hideChildVirtualDirectories").Value = true;

adminManager.CommitChanges();