Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim authenticationSection As ConfigurationSection = config.GetSection ("system.ftpServer/security/authentication")
      Dim denyByFailureElement As ConfigurationElement = authenticationSection.GetChildElement("denyByFailure")
      denyByFailureElement("enabled") = true
      denyByFailureElement("maxFailure") = 10
      denyByFailureElement("entryExpiration") = TimeSpan.Parse("00:00:35")
      denyByFailureElement("loggingOnlyMode") = false
      serverManager.CommitChanges
   End Sub
End Module