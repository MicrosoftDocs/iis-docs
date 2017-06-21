Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set validationSection = adminManager.GetAdminSection("system.webServer/validation", "MACHINE/WEBROOT/APPHOST/Default Web Site")
validationSection.Properties.Item("validateIntegratedModeConfiguration").Value = True

adminManager.CommitChanges()