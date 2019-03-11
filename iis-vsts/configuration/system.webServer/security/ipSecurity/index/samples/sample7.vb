Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set ipSecuritySection = adminManager.GetAdminSection("system.webServer/security/ipSecurity", "MACHINE/WEBROOT/APPHOST/Default Web Site")

ipSecuritySection.Properties.Item("enableReverseDns").Value = True

adminManager.CommitChanges()