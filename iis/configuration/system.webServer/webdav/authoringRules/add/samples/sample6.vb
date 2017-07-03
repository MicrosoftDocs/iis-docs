Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set authoringRulesSection = adminManager.GetAdminSection("system.webServer/webdav/authoringRules", "MACHINE/WEBROOT/APPHOST/Default Web Site")
authoringRulesSection.Properties.Item("allowNonMimeMapFiles").Value = True

Set authoringRulesCollection = authoringRulesSection.Collection

Set addElement = authoringRulesCollection.CreateNewElement("add")
addElement.Properties.Item("roles").Value = "administrators"
addElement.Properties.Item("path").Value = "*"
addElement.Properties.Item("access").Value = "Read, Write, Source"
authoringRulesCollection.AddElement(addElement)

adminManager.CommitChanges()