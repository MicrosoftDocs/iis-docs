Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")

      Dim applicationDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("applicationDefaults")
      applicationDefaultsElement("applicationPool") = "DefaultAppPool"

      serverManager.CommitChanges()
   End Sub

End Module