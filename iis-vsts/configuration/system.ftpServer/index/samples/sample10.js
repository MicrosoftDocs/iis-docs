var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var serverRuntimeSection = adminManager.GetAdminSection("system.ftpServer/serverRuntime", "MACHINE/WEBROOT/APPHOST");
var hostNameSupportElement = serverRuntimeSection.ChildElements.Item("hostNameSupport");
hostNameSupportElement.Properties.Item("useDomainNameAsHostName").Value = true;

adminManager.CommitChanges();