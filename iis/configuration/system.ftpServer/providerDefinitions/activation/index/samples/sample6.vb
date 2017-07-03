Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set providerDefinitionsSection = adminManager.GetAdminSection("system.ftpServer/providerDefinitions", "MACHINE/WEBROOT/APPHOST")
Set providerDefinitionsCollection = providerDefinitionsSection.Collection

Set addElement = providerDefinitionsCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "FtpXmlAuthentication"
addElement.Properties.Item("type").Value = "FtpXmlAuthentication, FtpXmlAuthentication, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
providerDefinitionsCollection.AddElement(addElement)

Set activationCollection = providerDefinitionsSection.ChildElements.Item("activation").Collection
Set providerDataElement = activationCollection.CreateNewElement("providerData")
providerDataElement.Properties.Item("name").Value = "FtpXmlAuthentication"
Set providerDataCollection = providerDataElement.Collection

Set addElement1 = providerDataCollection.CreateNewElement("add")
addElement1.Properties.Item("key").Value = "xmlFileName"
addElement1.Properties.Item("value").Value = "C:\Inetpub\wwwroot\App_Data\Users.xml"
providerDataCollection.AddElement(addElement1)
activationCollection.AddElement(providerDataElement)

adminManager.CommitChanges()