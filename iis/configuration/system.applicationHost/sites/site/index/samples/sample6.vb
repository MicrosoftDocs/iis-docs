Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set sitesCollection = sitesSection.Collection

Set siteElement = sitesCollection.CreateNewElement("site")
siteElement.Properties.Item("name").Value = "Contoso"
siteElement.Properties.Item("id").Value = 2
siteElement.Properties.Item("serverAutoStart").Value = True

Set bindingsCollection = siteElement.ChildElements.Item("bindings").Collection
Set bindingElement = bindingsCollection.CreateNewElement("binding")
bindingElement.Properties.Item("protocol").Value = "http"
bindingElement.Properties.Item("bindingInformation").Value = "*:80:www.contoso.com"
bindingsCollection.AddElement bindingElement

Set siteCollection = siteElement.Collection
Set applicationElement = siteCollection.CreateNewElement("application")
applicationElement.Properties.Item("path").Value = "/"
Set applicationCollection = applicationElement.Collection
Set virtualDirectoryElement = applicationCollection.CreateNewElement("virtualDirectory")
virtualDirectoryElement.Properties.Item("path").Value = "/"
virtualDirectoryElement.Properties.Item("physicalPath").Value = "C:\Inetpub\www.contoso.com\wwwroot"
applicationCollection.AddElement(virtualDirectoryElement)
siteCollection.AddElement applicationElement
sitesCollection.AddElement siteElement

adminManager.CommitChanges()