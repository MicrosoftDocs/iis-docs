var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var sitesCollection = sitesSection.Collection;

var siteElement = sitesCollection.CreateNewElement("site");
siteElement.Properties.Item("name").Value = "Contoso";
siteElement.Properties.Item("id").Value = 2;
siteElement.Properties.Item("serverAutoStart").Value = true;

var bindingsCollection = siteElement.ChildElements.Item("bindings").Collection;
var bindingElement = bindingsCollection.CreateNewElement("binding");
bindingElement.Properties.Item("protocol").Value = "http";
bindingElement.Properties.Item("bindingInformation").Value = "*:80:www.contoso.com";
bindingsCollection.AddElement(bindingElement);

var siteCollection = siteElement.Collection;
var applicationElement = siteCollection.CreateNewElement("application");
applicationElement.Properties.Item("path").Value = "/";
var applicationCollection = applicationElement.Collection;
var virtualDirectoryElement = applicationCollection.CreateNewElement("virtualDirectory");
virtualDirectoryElement.Properties.Item("path").Value = "/";
virtualDirectoryElement.Properties.Item("physicalPath").Value = "C:\\Inetpub\\www.contoso.com\\wwwroot";
applicationCollection.AddElement(virtualDirectoryElement);
siteCollection.AddElement(applicationElement);
sitesCollection.AddElement(siteElement);

adminManager.CommitChanges();