Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim fastCgiSection As ConfigurationSection = config.GetSection("system.webServer/fastCgi")
      Dim fastCgiCollection As ConfigurationElementCollection = fastCgiSection.GetCollection
      Dim applicationElement As ConfigurationElement = fastCgiCollection.CreateElement("application")
      applicationElement("fullPath") = "C:\PHP\php-cgi.exe"
      applicationElement("arguments") = ""
      applicationElement("maxInstances") = 4
      applicationElement("idleTimeout") = 300
      applicationElement("activityTimeout") = 30
      applicationElement("requestTimeout") = 90
      applicationElement("instanceMaxRequests") = 10000
      applicationElement("protocol") = "NamedPipe"
      applicationElement("flushNamedPipe") = False

      Dim environmentVariablesCollection As ConfigurationElementCollection = applicationElement.GetCollection("environmentVariables")
      Dim environmentVariableElement As ConfigurationElement = environmentVariablesCollection.CreateElement("environmentVariable")
      environmentVariableElement("name") = "PHP_FCGI_MAX_REQUESTS"
      environmentVariableElement("value") = "10000"
      environmentVariablesCollection.Add(environmentVariableElement)
      fastCgiCollection.Add(applicationElement)

      Dim handlersSection As ConfigurationSection = config.GetSection("system.webServer/handlers")
      Dim handlersCollection As ConfigurationElementCollection = handlersSection.GetCollection
      Dim addElement As ConfigurationElement = handlersCollection.CreateElement("add")
      addElement("name") = "PHP-FastCGI"
      addElement("path") = "*.php"
      addElement("verb") = "GET,HEAD,POST"
      addElement("modules") = "FastCgiModule"
      addElement("scriptProcessor") = "C:\PHP\php-cgi.exe"
      addElement("resourceType") = "Either"
      addElement("requireAccess") = "Script"
      handlersCollection.AddAt(0, addElement)

      serverManager.CommitChanges()
   End Sub

End Module