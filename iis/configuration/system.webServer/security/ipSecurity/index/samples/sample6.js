var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var ipSecuritySection = adminManager.GetAdminSection("system.webServer/security/ipSecurity", "MACHINE/WEBROOT/APPHOST/Default Web Site");

ipSecuritySection.Properties.Item("enableReverseDns").Value = True;

adminManager.CommitChanges();