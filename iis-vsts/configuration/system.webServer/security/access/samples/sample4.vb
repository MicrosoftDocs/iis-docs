Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim accessSection As ConfigurationSection = config.GetSection("system.webServer/security/access", "Contoso")
      accessSection("sslFlags") = "Ssl"
      serverManager.CommitChanges()
   End Sub
End Module