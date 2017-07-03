var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var listenerAdaptersSection = adminManager.GetAdminSection("system.applicationHost/listenerAdapters", "MACHINE/WEBROOT/APPHOST");
var listenerAdaptersCollection = listenerAdaptersSection.Collection;

var addElement = listenerAdaptersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "gopher";
addElement.Properties.Item("protocolManagerDll").Value = "%SystemRoot%\\system32\\inetsrv\\gophersvc.dll";
addElement.Properties.Item("protocolManagerDllInitFunction").Value = "GopherInit";
listenerAdaptersCollection.AddElement(addElement);

adminManager.CommitChanges();