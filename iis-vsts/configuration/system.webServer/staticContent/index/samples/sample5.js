var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var staticContentSection = adminManager.GetAdminSection("system.webServer/staticContent", "MACHINE/WEBROOT/APPHOST/Default Web Site");
staticContentSection.Properties.Item("defaultDocFooter").Value = "The information in this web site is copyrighted.";
staticContentSection.Properties.Item("enableDocFooter").Value = true;

adminManager.CommitChanges();