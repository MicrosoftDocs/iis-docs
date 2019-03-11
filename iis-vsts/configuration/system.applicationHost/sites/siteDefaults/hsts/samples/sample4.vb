Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")

      Dim hstsElement As ConfigurationElement = siteDefaultsElement.GetChildElement("hsts")
      hstsElement("enabled") = True
      hstsElement("max-age") = 31536000
      hstsElement("includeSubDomains") = True
      hstsElement("redirectHttpToHttps") = True

      serverManager.CommitChanges()
   End Sub

End Module