Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim cgiSection As ConfigurationSection = config.GetSection("system.webServer/cgi", "Default Web Site")

      cgiSection("createCGIWithNewConsole") = True
      cgiSection("createProcessAsUser") = False
      cgiSection("timeout") = TimeSpan.Parse("00:20:00")

      serverManager.CommitChanges()
   End Sub

End Module