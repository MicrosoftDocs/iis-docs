Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")

      Dim bindingsCollection As ConfigurationElementCollection = siteDefaultsElement.GetCollection("bindings")
      Dim bindingElement As ConfigurationElement = bindingsCollection.CreateElement("binding")
      bindingElement("protocol") = "http"
      bindingElement("bindingInformation") = "127.0.0.1:8080:"
      bindingsCollection.Add(bindingElement)

      serverManager.CommitChanges()
   End Sub

End Module