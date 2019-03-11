var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST/Contoso");
aspSection.Properties.Item("enableParentPaths").Value = false;
aspSection.Properties.Item("bufferingOn").Value = true;
var sessionElement = aspSection.ChildElements.Item("session");
sessionElement.Properties.Item("allowSessionState").Value = true;

adminManager.CommitChanges();