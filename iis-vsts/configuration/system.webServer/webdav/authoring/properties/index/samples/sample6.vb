Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set propertiesElement = authoringSection.ChildElements.Item("properties")
propertiesElement.Properties.Item("allowAnonymousPropfind").Value = False
propertiesElement.Properties.Item("allowInfinitePropfindDepth").Value = False
propertiesElement.Properties.Item("allowCustomProperties").Value = True

Set propertiesCollection = propertiesElement.Collection

Set addElement = propertiesCollection.CreateNewElement("add")
addElement.Properties.Item("xmlNamespace").Value = "*"
addElement.Properties.Item("propertyStore").Value = "webdav_simple_prop"
propertiesCollection.AddElement(addElement)

adminManager.CommitChanges()