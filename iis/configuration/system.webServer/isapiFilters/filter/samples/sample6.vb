Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set isapiFiltersSection = adminManager.GetAdminSection("system.webServer/isapiFilters", "MACHINE/WEBROOT/APPHOST")
Set isapiFiltersCollection = isapiFiltersSection.Collection

Set filterElement = isapiFiltersCollection.CreateNewElement("filter")
filterElement.Properties.Item("name").Value = "SalesQueryIsapi"
filterElement.Properties.Item("path").Value = "c:\\Inetpub\\www.contoso.com\\filters\\SalesQueryIsapi.dll"
filterElement.Properties.Item("enabled").Value = True
filterElement.Properties.Item("enableCache").Value = True
isapiFiltersCollection.AddElement filterElement

adminManager.CommitChanges()