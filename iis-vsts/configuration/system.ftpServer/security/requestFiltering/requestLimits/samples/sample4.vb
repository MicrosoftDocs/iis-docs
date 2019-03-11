Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.ftpServer/security/requestFiltering", "Default Web Site")

      Dim requestLimitsElement As ConfigurationElement = requestFilteringSection.GetChildElement("requestLimits")
      requestLimitsElement("maxAllowedContentLength") = 1000000
      requestLimitsElement("maxUrl") = 1024

      serverManager.CommitChanges()
   End Sub
End Module