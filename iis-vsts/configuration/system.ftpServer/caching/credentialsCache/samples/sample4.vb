Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim cachingSection As ConfigurationSection = config.GetSection("system.ftpServer/caching")

      Dim credentialsCacheElement As ConfigurationElement = cachingSection.GetChildElement("credentialsCache")
      credentialsCacheElement("enabled") = True
      credentialsCacheElement("flushInterval") = 300

      serverManager.CommitChanges()
   End Sub
End Module