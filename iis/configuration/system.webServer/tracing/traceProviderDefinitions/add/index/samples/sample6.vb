Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set traceProviderDefinitionsSection = adminManager.GetAdminSection("system.webServer/tracing/traceProviderDefinitions", "MACHINE/WEBROOT/APPHOST")
Set traceProviderDefinitionsCollection = traceProviderDefinitionsSection.Collection

Set addElement = traceProviderDefinitionsCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "MyTraceProvider"
addElement.Properties.Item("guid").Value = "{00000000-0000-0000-0000-00000000000}"
Set areasCollection = addElement.ChildElements.Item("areas").Collection

Set addElement1 = areasCollection.CreateNewElement("add")
addElement1.Properties.Item("name").Value = "ProviderAreaOne"
addElement1.Properties.Item("value").Value = 0
areasCollection.AddElement addElement1

Set addElement2 = areasCollection.CreateNewElement("add")
addElement2.Properties.Item("name").Value = "ProviderAreaTwo"
addElement2.Properties.Item("value").Value = 1
areasCollection.AddElement addElement2

traceProviderDefinitionsCollection.AddElement addElement
adminManager.CommitChanges()