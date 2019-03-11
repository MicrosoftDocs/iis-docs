Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set httpRedirectSection = adminManager.GetAdminSection("system.webServer/httpRedirect", "MACHINE/WEBROOT/APPHOST/Default Web Site")
httpRedirectSection.Properties.Item("enabled").Value = True
httpRedirectSection.Properties.Item("destination").Value = "http://www.contoso.com"
httpRedirectSection.Properties.Item("exactDestination").Value = False
httpRedirectSection.Properties.Item("httpResponseStatus").Value = "Found"

adminManager.CommitChanges()