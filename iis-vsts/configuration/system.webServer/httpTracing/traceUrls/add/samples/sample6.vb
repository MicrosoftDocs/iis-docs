Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set httpTracingSection = adminManager.GetAdminSection("system.webServer/httpTracing", "MACHINE/WEBROOT/APPHOST/Contoso")

Set traceUrlsCollection = httpTracingSection.ChildElements.Item("traceUrls").Collection
Set addElement = traceUrlsCollection.CreateNewElement("add")
addElement.Properties.Item("value").Value = "/iisstart.htm"
traceUrlsCollection.AddElement addElement

adminManager.CommitChanges()