var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var urlCompressionSection = adminManager.GetAdminSection("system.webServer/urlCompression", "MACHINE/WEBROOT/APPHOST/Default Web Site");
urlCompressionSection.Properties.Item("doStaticCompression").Value = true;
urlCompressionSection.Properties.Item("doDynamicCompression").Value = false;

adminManager.CommitChanges();