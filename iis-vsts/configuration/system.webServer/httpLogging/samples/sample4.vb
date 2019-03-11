Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim httpLoggingSection As ConfigurationSection = config.GetSection("system.webServer/httpLogging", "Contoso")
      httpLoggingSection("selectiveLogging") = "LogAll"
      httpLoggingSection("dontLog") = True
      serverManager.CommitChanges()
   End Sub
End Module