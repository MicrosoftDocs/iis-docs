Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim isapiFiltersSection As ConfigurationSection = config.GetSection("system.webServer/isapiFilters")
      Dim isapiFiltersCollection As ConfigurationElementCollection = isapiFiltersSection.GetCollection
      Dim filterElement As ConfigurationElement = isapiFiltersCollection.CreateElement("filter")
      filterElement("name") = "SalesQueryIsapi"
      filterElement("path") = "c:\Inetpub\www.contoso.com\filters\SalesQueryIsapi.dll"
      filterElement("enabled") = True
      filterElement("enableCache") = True
      isapiFiltersCollection.Add(filterElement)
      serverManager.CommitChanges()
   End Sub
End Module