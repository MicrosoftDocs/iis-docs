Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim authoringSection As ConfigurationSection = config.GetSection("system.webServer/webdav/authoring", "Default Web Site")
      authoringSection("enabled") = True
      authoringSection("requireSsl") = False

      serverManager.CommitChanges()
   End Sub
End Module