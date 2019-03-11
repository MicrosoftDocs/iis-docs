var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var isapiFiltersSection = adminManager.GetAdminSection("system.webServer/isapiFilters", "MACHINE/WEBROOT/APPHOST");
var isapiFiltersCollection = isapiFiltersSection.Collection;

var filterElement = isapiFiltersCollection.CreateNewElement("filter");
filterElement.Properties.Item("name").Value = "SalesQueryIsapi";
filterElement.Properties.Item("path").Value = "c:\\Inetpub\\www.contoso.com\\filters\\SalesQueryIsapi.dll";
filterElement.Properties.Item("enabled").Value = true;
filterElement.Properties.Item("enableCache").Value = true;
isapiFiltersCollection.AddElement(filterElement);

adminManager.CommitChanges();