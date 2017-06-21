Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim aspSection As ConfigurationSection = config.GetSection("system.webServer/asp")

      Dim cacheElement As ConfigurationElement = aspSection.GetChildElement("cache")
      cacheElement("diskTemplateCacheDirectory") = "%SystemDrive%\inetpub\temp\ASP Compiled Templates"
      cacheElement("maxDiskTemplateCacheFiles") = 4000
      cacheElement("scriptFileCacheSize") = 1000
      cacheElement("scriptEngineCacheMax") = 500

      serverManager.CommitChanges()
   End Sub

End Module