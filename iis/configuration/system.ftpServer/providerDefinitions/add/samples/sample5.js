var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var providerDefinitionsSection = adminManager.GetAdminSection("system.ftpServer/providerDefinitions", "MACHINE/WEBROOT/APPHOST");
var providerDefinitionsCollection = providerDefinitionsSection.Collection;

var addElement = providerDefinitionsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "FtpXmlAuthentication";
addElement.Properties.Item("type").Value = "FtpXmlAuthentication, FtpXmlAuthentication, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
providerDefinitionsCollection.AddElement(addElement);

adminManager.CommitChanges();