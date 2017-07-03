var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var httpProtocolSection = adminManager.GetAdminSection("system.webServer/httpProtocol", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var customHeadersCollection = httpProtocolSection.ChildElements.Item("customHeaders").Collection;

var addElement = customHeadersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "X-Custom-Name";
addElement.Properties.Item("value").Value = "MyCustomValue";
customHeadersCollection.AddElement(addElement);

adminManager.CommitChanges();