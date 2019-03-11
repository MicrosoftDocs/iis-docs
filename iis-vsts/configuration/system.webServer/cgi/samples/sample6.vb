Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set cgiSection = adminManager.GetAdminSection("system.webServer/cgi", "MACHINE/WEBROOT/APPHOST/Default Web Site")

cgiSection.Properties.Item("createCGIWithNewConsole").Value = True
cgiSection.Properties.Item("createProcessAsUser").Value = False
cgiSection.Properties.Item("timeout").Value = "00:20:00"

adminManager.CommitChanges()