var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var alwaysAllowedUrlsCollection = requestFilteringSection.ChildElements.Item("alwaysAllowedUrls").Collection;
var addElement = alwaysAllowedUrlsCollection.CreateNewElement("add");
addElement.Properties.Item("url").Value = "/allowed_url.aspx";
alwaysAllowedUrlsCollection.AddElement(addElement);

adminManager.CommitChanges();