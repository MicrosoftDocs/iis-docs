var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var httpTracingSection = adminManager.GetAdminSection("system.webServer/httpTracing", "MACHINE/WEBROOT/APPHOST/Contoso");

var traceUrlsCollection = httpTracingSection.ChildElements.Item("traceUrls").Collection;
var addElement = traceUrlsCollection.CreateNewElement("add");
addElement.Properties.Item("value").Value = "/iisstart.htm";
traceUrlsCollection.AddElement(addElement);

adminManager.CommitChanges();