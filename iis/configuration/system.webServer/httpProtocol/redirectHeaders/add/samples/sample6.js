var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var httpProtocolSection = adminManager.GetAdminSection("system.webServer/httpProtocol", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var redirectHeadersCollection = httpProtocolSection.ChildElements.Item("redirectHeaders").Collection;

var addElement = redirectHeadersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "X-Custom-Redirect-Header";
addElement.Properties.Item("value").Value = "MyRedirectValue";
redirectHeadersCollection.AddElement(addElement);

adminManager.CommitChanges();