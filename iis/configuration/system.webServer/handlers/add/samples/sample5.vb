Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim appHostConfig As Configuration = serverManager.GetApplicationHostConfiguration
      Dim fastCgiSection As ConfigurationSection = appHostConfig.GetSection("system.webServer/fastCgi")
      Dim fastCgiCollection As ConfigurationElementCollection = fastCgiSection.GetCollection
      Dim applicationElement As ConfigurationElement = fastCgiCollection.CreateElement("application")
      applicationElement("fullPath") = "c:\php\php-cgi.exe"
      fastCgiCollection.Add(applicationElement)

      Dim webConfig As Configuration = serverManager.GetWebConfiguration("Contoso")
      Dim handlersSection As ConfigurationSection = webConfig.GetSection("system.webServer/handlers")
      Dim handlersCollection As ConfigurationElementCollection = handlersSection.GetCollection
      Dim addElement As ConfigurationElement = handlersCollection.CreateElement("add")
      addElement("name") = "PHP-FastCGI"
      addElement("path") = "*.php"
      addElement("verb") = "GET,HEAD,POST"
      addElement("modules") = "FastCgiModule"
      addElement("scriptProcessor") = "c:\php\php-cgi.exe"
      addElement("resourceType") = "Either"
      handlersCollection.AddAt(0, addElement)

      serverManager.CommitChanges()
   End Sub
End Module