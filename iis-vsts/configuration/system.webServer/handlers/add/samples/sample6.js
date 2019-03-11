var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');

adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var fastCgiSection = adminManager.GetAdminSection("system.webServer/fastCgi", "MACHINE/WEBROOT/APPHOST");
var fastCgiCollection = fastCgiSection.Collection;
var applicationElement = fastCgiCollection.CreateNewElement("application");
applicationElement.Properties.Item("fullPath").Value = "c:\\php\\php-cgi.exe";
fastCgiCollection.AddElement(applicationElement);
adminManager.CommitChanges();

adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso";
var handlersSection = adminManager.GetAdminSection("system.webServer/handlers", "MACHINE/WEBROOT/APPHOST/Contoso");
var handlersCollection = handlersSection.Collection;
var addElement = handlersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "PHP-FastCGI";
addElement.Properties.Item("path").Value = "*.php";
addElement.Properties.Item("verb").Value = "GET,HEAD,POST";
addElement.Properties.Item("modules").Value = "FastCgiModule";
addElement.Properties.Item("scriptProcessor").Value = "c:\\php\\php-cgi.exe";
addElement.Properties.Item("resourceType").Value = "Either";
handlersCollection.AddElement(addElement, 0);
adminManager.CommitChanges();