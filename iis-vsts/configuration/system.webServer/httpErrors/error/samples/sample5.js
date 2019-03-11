var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var httpErrorsSection = adminManager.GetAdminSection("system.webServer/httpErrors", "MACHINE/WEBROOT/APPHOST");
var httpErrorsCollection = httpErrorsSection.Collection;

var errorElement = httpErrorsCollection.CreateNewElement("error");
errorElement.Properties.Item("statusCode").Value = 404;
errorElement.Properties.Item("subStatusCode").Value = 5;
errorElement.Properties.Item("prefixLanguageFilePath").Value = "%SystemDrive%\\inetpub\\custerr";
errorElement.Properties.Item("path").Value = "404.5.htm";
httpErrorsCollection.AddElement(errorElement);

adminManager.CommitChanges();