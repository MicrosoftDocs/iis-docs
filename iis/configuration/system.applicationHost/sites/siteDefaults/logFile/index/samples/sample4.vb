Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")

      Dim logFileElement As ConfigurationElement = siteDefaultsElement.GetChildElement("logFile")
      logFileElement("logFormat") = "W3C"
      logFileElement("directory") = "%SystemDrive%\inetpub\logs\LogFiles"
      logFileElement("enabled") = True

      serverManager.CommitChanges()
   End Sub

End Module