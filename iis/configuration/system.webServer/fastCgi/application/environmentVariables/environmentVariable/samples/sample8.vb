Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set fastCgiSection = adminManager.GetAdminSection("system.webServer/fastCgi", "MACHINE/WEBROOT/APPHOST")
Set fastCgiCollection = fastCgiSection.Collection
Set applicationElement = fastCgiCollection.CreateNewElement("application")
applicationElement.Properties.Item("fullPath").Value = "C:\PHP\php-cgi.exe"
applicationElement.Properties.Item("arguments").Value = ""
applicationElement.Properties.Item("maxInstances").Value = 4
applicationElement.Properties.Item("idleTimeout").Value = 300
applicationElement.Properties.Item("activityTimeout").Value = 30
applicationElement.Properties.Item("requestTimeout").Value = 90
applicationElement.Properties.Item("instanceMaxRequests").Value = 10000
applicationElement.Properties.Item("protocol").Value = "NamedPipe"
applicationElement.Properties.Item("queueLength").Value = 1000
applicationElement.Properties.Item("flushNamedPipe").Value = false
applicationElement.Properties.Item("rapidFailsPerMinute").Value = 10

Set environmentVariablesCollection = applicationElement.ChildElements.Item("environmentVariables").Collection
Set environmentVariableElement = environmentVariablesCollection.CreateNewElement("environmentVariable")
environmentVariableElement.Properties.Item("name").Value = "PHP_FCGI_MAX_REQUESTS"
environmentVariableElement.Properties.Item("value").Value = "10000"
environmentVariablesCollection.AddElement(environmentVariableElement)
Call fastCgiCollection.AddElement(applicationElement)

Set handlersSection = adminManager.GetAdminSection("system.webServer/handlers", "MACHINE/WEBROOT/APPHOST")
Set handlersCollection = handlersSection.Collection
Set addElement = handlersCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "PHP-FastCGI"
addElement.Properties.Item("path").Value = "*.php"
addElement.Properties.Item("verb").Value = "GET,HEAD,POST"
addElement.Properties.Item("modules").Value = "FastCgiModule"
addElement.Properties.Item("scriptProcessor").Value = "C:\PHP\php-cgi.exe"
addElement.Properties.Item("resourceType").Value = "Either"
addElement.Properties.Item("requireAccess").Value = "Script"
Call handlersCollection.AddElement(addElement, 0)

adminManager.CommitChanges()