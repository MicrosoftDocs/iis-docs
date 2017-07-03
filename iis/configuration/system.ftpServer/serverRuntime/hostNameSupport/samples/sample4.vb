Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim serverRuntimeSection As ConfigurationSection = config.GetSection("system.ftpServer/serverRuntime")

      Dim hostNameSupportElement As ConfigurationElement = serverRuntimeSection.GetChildElement("hostNameSupport")
      hostNameSupportElement("useDomainNameAsHostName") = True

      serverManager.CommitChanges()
   End Sub
End Module