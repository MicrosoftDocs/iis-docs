Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")

Set bindingsCollection = siteDefaultsElement.ChildElements.Item("bindings").Collection
Set bindingElement = bindingsCollection.CreateNewElement("binding")
bindingElement.Properties.Item("protocol").Value = "http"
bindingElement.Properties.Item("bindingInformation").Value = "127.0.0.1:8080:"
bindingsCollection.AddElement(bindingElement)

adminManager.CommitChanges()