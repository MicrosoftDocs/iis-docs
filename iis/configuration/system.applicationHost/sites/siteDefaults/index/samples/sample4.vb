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
      limitsElement("connectionTimeout") = TimeSpan.Parse("00:02:00")

      Dim logFileElement As ConfigurationElement = siteDefaultsElement.GetChildElement("logFile")
      logFileElement("logFormat") = "W3C"
      logFileElement("directory") = "%SystemDrive%\inetpub\logs\LogFiles"
      logFileElement("enabled") = True

      Dim traceFailedRequestsLoggingElement As ConfigurationElement = siteDefaultsElement.GetChildElement("traceFailedRequestsLogging")
      traceFailedRequestsLoggingElement("enabled") = True
      traceFailedRequestsLoggingElement("directory") = "%SystemDrive%\inetpub\logs\FailedReqLogFiles"
      traceFailedRequestsLoggingElement("maxLogFiles") = 20

      Dim bindingsCollection As ConfigurationElementCollection = siteDefaultsElement.GetCollection("bindings")
      Dim bindingElement As ConfigurationElement = bindingsCollection.CreateElement("binding")
      bindingElement("protocol") = "http"
      bindingElement("bindingInformation") = "127.0.0.1:8080:"
      bindingsCollection.Add(bindingElement)

      Dim ftpServerElement As ConfigurationElement = siteDefaultsElement.GetChildElement("ftpServer")
      ftpServerElement("serverAutoStart") = true

      serverManager.CommitChanges()
   End Sub

End Module