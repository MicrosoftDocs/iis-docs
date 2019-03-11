Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim logSection As ConfigurationSection = config.GetSection("system.ftpServer/log")
      logSection("centralLogFileMode") = "Central"

      Dim centralLogFileElement As ConfigurationElement = logSection.GetChildElement("centralLogFile")
      centralLogFileElement("enabled") = True

      serverManager.CommitChanges()
   End Sub
End Module