Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")

      Dim validationSection As ConfigurationSection = config.GetSection("system.webServer/validation")
      validationSection("validateIntegratedModeConfiguration") = True

      serverManager.CommitChanges()
   End Sub

End Module