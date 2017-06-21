Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim sitesCollection As ConfigurationElementCollection = sitesSection.GetCollection

      Dim siteElement As ConfigurationElement = sitesCollection.CreateElement("site")
      siteElement("name") = "Contoso"
      siteElement("id") = 2
      siteElement("serverAutoStart") = True

      Dim bindingsCollection As ConfigurationElementCollection = siteElement.GetCollection("bindings")
      Dim bindingElement As ConfigurationElement = bindingsCollection.CreateElement("binding")
      bindingElement("protocol") = "http"
      bindingElement("bindingInformation") = "*:80:www.contoso.com"
      bindingsCollection.Add(bindingElement)

      Dim siteCollection As ConfigurationElementCollection = siteElement.GetCollection
      Dim applicationElement As ConfigurationElement = siteCollection.CreateElement("application")
      applicationElement("path") = "/"
      Dim applicationCollection As ConfigurationElementCollection = applicationElement.GetCollection
      Dim virtualDirectoryElement As ConfigurationElement = applicationCollection.CreateElement("virtualDirectory")
      virtualDirectoryElement("path") = "/"
      virtualDirectoryElement("physicalPath") = "C:\Inetpub\www.contoso.com\wwwroot"
      applicationCollection.Add(virtualDirectoryElement)
      siteCollection.Add(applicationElement)
      sitesCollection.Add(siteElement)

      serverManager.CommitChanges()
   End Sub
End Module