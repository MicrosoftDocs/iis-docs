var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var traceProviderDefinitionsSection = adminManager.GetAdminSection("system.webServer/tracing/traceProviderDefinitions", "MACHINE/WEBROOT/APPHOST");
var traceProviderDefinitionsCollection = traceProviderDefinitionsSection.Collection;

var addElement = traceProviderDefinitionsCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "MyTraceProvider";
addElement.Properties.Item("guid").Value = "{00000000-0000-0000-0000-00000000000}";
var areasCollection = addElement.ChildElements.Item("areas").Collection;

var addElement1 = areasCollection.CreateNewElement("add");
addElement1.Properties.Item("name").Value = "ProviderAreaOne";
addElement1.Properties.Item("value").Value = 0;
areasCollection.AddElement(addElement1);

var addElement2 = areasCollection.CreateNewElement("add");
addElement2.Properties.Item("name").Value = "ProviderAreaTwo";
addElement2.Properties.Item("value").Value = 1;
areasCollection.AddElement(addElement2);

traceProviderDefinitionsCollection.AddElement(addElement);
adminManager.CommitChanges();