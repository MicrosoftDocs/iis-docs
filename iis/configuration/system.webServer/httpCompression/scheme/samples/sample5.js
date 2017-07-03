var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var httpCompressionSection = adminManager.GetAdminSection("system.webServer/httpCompression", "MACHINE/WEBROOT/APPHOST");
var httpCompressionCollection = httpCompressionSection.Collection;

var schemeElement = httpCompressionCollection.CreateNewElement("scheme");
schemeElement.Properties.Item("name").Value = "deflate";
schemeElement.Properties.Item("doStaticCompression").Value = true;
schemeElement.Properties.Item("doDynamicCompression").Value = true;
schemeElement.Properties.Item("dll").Value = "%Windir%\\system32\\inetsrv\\gzip.dll";
httpCompressionCollection.AddElement(schemeElement);

adminManager.CommitChanges();