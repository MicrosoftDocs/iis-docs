Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim serverRuntimeSection As ConfigurationSection = config.GetSection("system.webServer/serverRuntime", "Default Web Site")
      serverRuntimeSection("enabled") = True
      serverRuntimeSection("frequentHitThreshold") = 5
      serverRuntimeSection("frequentHitTimePeriod") = TimeSpan.Parse("00:00:20")

      serverManager.CommitChanges()
   End Sub

End Module