Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso"
Set traceFailedRequestsSection = adminManager.GetAdminSection("system.webServer/tracing/traceFailedRequests", "MACHINE/WEBROOT/APPHOST/Contoso")
Set traceFailedRequestsCollection = traceFailedRequestsSection.Collection

Set addElement = traceFailedRequestsCollection.CreateNewElement("add")
addElement.Properties.Item("path").Value = "*.aspx"
Set traceAreasCollection = addElement.ChildElements.Item("traceAreas").Collection

Set addElement1 = traceAreasCollection.CreateNewElement("add")
addElement1.Properties.Item("provider").Value = "ASPNET"
addElement1.Properties.Item("areas").Value = "Infrastructure,Module,Page,AppServices"
addElement1.Properties.Item("verbosity").Value = "Verbose"
traceAreasCollection.AddElement addElement1

Set failureDefinitionsElement = addElement.ChildElements.Item("failureDefinitions")
failureDefinitionsElement.Properties.Item("statusCodes").Value = "500"
traceFailedRequestsCollection.AddElement addElement

adminManager.CommitChanges()