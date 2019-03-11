Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")

      Dim virtualDirectoryDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("virtualDirectoryDefaults")
      virtualDirectoryDefaultsElement("logonMethod") = "Network"

      serverManager.CommitChanges()
   End Sub

End Module