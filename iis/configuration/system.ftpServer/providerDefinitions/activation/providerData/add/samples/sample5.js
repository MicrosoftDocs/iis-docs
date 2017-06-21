var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var providerDefinitionsSection = adminManager.GetAdminSection("system.ftpServer/providerDefinitions", "MACHINE/WEBROOT/APPHOST");
var providerDefinitionsCollection = providerDefinitionsSection.Collection;

var addElement = providerDefinitionsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "FtpXmlAuthentication";
addElement.Properties.Item("type").Value = "FtpXmlAuthentication, FtpXmlAuthentication, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
providerDefinitionsCollection.AddElement(addElement);

var activationCollection = providerDefinitionsSection.ChildElements.Item("activation").Collection;
var providerDataElement = activationCollection.CreateNewElement("providerData");
providerDataElement.Properties.Item("name").Value = "FtpXmlAuthentication";
var providerDataCollection = providerDataElement.Collection;

var addElement1 = providerDataCollection.CreateNewElement("add");
addElement1.Properties.Item("key").Value = "xmlFileName";
addElement1.Properties.Item("value").Value = "C:\\Inetpub\\wwwroot\\App_Data\\Users.xml";
providerDataCollection.AddElement(addElement1);
activationCollection.AddElement(providerDataElement);

adminManager.CommitChanges();