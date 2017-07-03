var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var httpRedirectSection = adminManager.GetAdminSection("system.webServer/httpRedirect", "MACHINE/WEBROOT/APPHOST/Default Web Site");
httpRedirectSection.Properties.Item("enabled").Value = true;
httpRedirectSection.Properties.Item("exactDestination").Value = true;
httpRedirectSection.Properties.Item("httpResponseStatus").Value = "Found";

var httpRedirectCollection = httpRedirectSection.Collection;
var addElement = httpRedirectCollection.CreateNewElement("add");
addElement.Properties.Item("wildcard").Value = "*.asp";
addElement.Properties.Item("destination").Value = "/default.htm";
httpRedirectCollection.AddElement(addElement);

adminManager.CommitChanges();