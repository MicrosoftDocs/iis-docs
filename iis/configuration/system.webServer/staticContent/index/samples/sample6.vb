Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set staticContentSection = adminManager.GetAdminSection("system.webServer/staticContent", "MACHINE/WEBROOT/APPHOST/Default Web Site")
staticContentSection.Properties.Item("defaultDocFooter").Value = "The information in this web site is copyrighted."
staticContentSection.Properties.Item("enableDocFooter").Value = True

adminManager.CommitChanges()