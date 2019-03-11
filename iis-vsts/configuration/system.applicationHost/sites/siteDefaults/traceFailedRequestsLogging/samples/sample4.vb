Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")

      Dim traceFailedRequestsLoggingElement As ConfigurationElement = siteDefaultsElement.GetChildElement("traceFailedRequestsLogging")
      traceFailedRequestsLoggingElement("enabled") = True
      traceFailedRequestsLoggingElement("directory") = "%SystemDrive%\inetpub\logs\FailedReqLogFiles"
      traceFailedRequestsLoggingElement("maxLogFiles") = 20

      serverManager.CommitChanges()
   End Sub

End Module