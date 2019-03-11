Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")

      Dim limitsElement As ConfigurationElement = siteDefaultsElement.GetChildElement("limits")
      limitsElement("connectionTimeout") = TimeSpan.Parse("00:03:00")

      serverManager.CommitChanges()
   End Sub

End Module