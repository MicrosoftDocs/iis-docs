Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim logSection As ConfigurationSection = config.GetSection("system.applicationHost/log")
      logSection("centralLogFileMode") = "CentralW3C"
      Dim centralW3CLogFileElement As ConfigurationElement = logSection.GetChildElement("centralW3CLogFile")
      centralW3CLogFileElement("period") = "Daily"

      serverManager.CommitChanges()
   End Sub

End Module