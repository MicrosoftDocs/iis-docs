Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set urlCompressionSection = adminManager.GetAdminSection("system.webServer/urlCompression", "MACHINE/WEBROOT/APPHOST/Default Web Site")
urlCompressionSection.Properties.Item("doStaticCompression").Value = True
urlCompressionSection.Properties.Item("doDynamicCompression").Value = False

adminManager.CommitChanges()