Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim serverSideIncludeSection As ConfigurationSection = config.GetSection("system.webServer/serverSideInclude", "Default Web Site")
      serverSideIncludeSection("ssiExecDisable") = True

      serverManager.CommitChanges()
   End Sub
End Module