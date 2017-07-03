var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var propertiesElement = authoringSection.ChildElements.Item("properties");
propertiesElement.Properties.Item("allowAnonymousPropfind").Value = false;
propertiesElement.Properties.Item("allowInfinitePropfindDepth").Value = false;
propertiesElement.Properties.Item("allowCustomProperties").Value = true;

var propertiesCollection = propertiesElement.Collection;

var addElement = propertiesCollection.CreateNewElement("add");
addElement.Properties.Item("xmlNamespace").Value = "*";
addElement.Properties.Item("propertyStore").Value = "webdav_simple_prop";
propertiesCollection.AddElement(addElement);

adminManager.CommitChanges();