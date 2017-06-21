Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set httpRedirectSection = adminManager.GetAdminSection("system.webServer/httpRedirect", "MACHINE/WEBROOT/APPHOST/Default Web Site")
httpRedirectSection.Properties.Item("enabled").Value = True
httpRedirectSection.Properties.Item("exactDestination").Value = True
httpRedirectSection.Properties.Item("httpResponseStatus").Value = "Found"

Set httpRedirectCollection = httpRedirectSection.Collection
Set addElement = httpRedirectCollection.CreateNewElement("add")
addElement.Properties.Item("wildcard").Value = "*.asp"
addElement.Properties.Item("destination").Value = "/default.htm"
httpRedirectCollection.AddElement(addElement)

adminManager.CommitChanges()