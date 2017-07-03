var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var fastCgiSection = adminManager.GetAdminSection("system.webServer/fastCgi", "MACHINE/WEBROOT/APPHOST");
var fastCgiCollection = fastCgiSection.Collection;
var applicationElement = fastCgiCollection.CreateNewElement("application");
applicationElement.Properties.Item("fullPath").Value = "C:\\PHP\\php-cgi.exe";
applicationElement.Properties.Item("arguments").Value = "";
applicationElement.Properties.Item("maxInstances").Value = 4;
applicationElement.Properties.Item("idleTimeout").Value = 300;
applicationElement.Properties.Item("activityTimeout").Value = 30;
applicationElement.Properties.Item("requestTimeout").Value = 90;
applicationElement.Properties.Item("instanceMaxRequests").Value = 10000;
applicationElement.Properties.Item("protocol").Value = "NamedPipe";
applicationElement.Properties.Item("queueLength").Value = 1000;
applicationElement.Properties.Item("flushNamedPipe").Value = false;
applicationElement.Properties.Item("rapidFailsPerMinute").Value = 10;

var environmentVariablesCollection = applicationElement.ChildElements.Item("environmentVariables").Collection;
var environmentVariableElement = environmentVariablesCollection.CreateNewElement("environmentVariable");
environmentVariableElement.Properties.Item("name").Value = "PHP_FCGI_MAX_REQUESTS";
environmentVariableElement.Properties.Item("value").Value = "10000";
environmentVariablesCollection.AddElement(environmentVariableElement);
fastCgiCollection.AddElement(applicationElement);

var handlersSection = adminManager.GetAdminSection("system.webServer/handlers", "MACHINE/WEBROOT/APPHOST");
var handlersCollection = handlersSection.Collection;
var addElement = handlersCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "PHP-FastCGI";
addElement.Properties.Item("path").Value = "*.php";
addElement.Properties.Item("verb").Value = "GET,HEAD,POST";
addElement.Properties.Item("modules").Value = "FastCgiModule";
addElement.Properties.Item("scriptProcessor").Value = "C:\\PHP\\php-cgi.exe";
addElement.Properties.Item("resourceType").Value = "Either";
addElement.Properties.Item("requireAccess").Value = "Script";
handlersCollection.AddElement(addElement, 0);

adminManager.CommitChanges();