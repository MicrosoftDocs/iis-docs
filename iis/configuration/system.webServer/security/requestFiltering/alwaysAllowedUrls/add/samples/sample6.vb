Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set alwaysAllowedUrlsCollection = requestFilteringSection.ChildElements.Item("alwaysAllowedUrls").Collection
Set addElement = alwaysAllowedUrlsCollection.CreateNewElement("add")
addElement.Properties.Item("url").Value = "/allowed_url.aspx"
alwaysAllowedUrlsCollection.AddElement(addElement)

adminManager.CommitChanges()