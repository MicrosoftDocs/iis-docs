var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso";
var traceFailedRequestsSection = adminManager.GetAdminSection("system.webServer/tracing/traceFailedRequests", "MACHINE/WEBROOT/APPHOST/Contoso");
var traceFailedRequestsCollection = traceFailedRequestsSection.Collection;

var addElement = traceFailedRequestsCollection.CreateNewElement("add");
addElement.Properties.Item("path").Value = "*.aspx";
var traceAreasCollection = addElement.ChildElements.Item("traceAreas").Collection;

var addElement1 = traceAreasCollection.CreateNewElement("add");
addElement1.Properties.Item("provider").Value = "ASPNET";
addElement1.Properties.Item("areas").Value = "Infrastructure,Module,Page,AppServices";
addElement1.Properties.Item("verbosity").Value = "Verbose";
traceAreasCollection.AddElement(addElement1);

var failureDefinitionsElement = addElement.ChildElements.Item("failureDefinitions");
failureDefinitionsElement.Properties.Item("statusCodes").Value = "500";
traceFailedRequestsCollection.AddElement(addElement);

adminManager.CommitChanges();