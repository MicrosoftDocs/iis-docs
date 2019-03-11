Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim webLimitsSection As ConfigurationSection = config.GetSection("system.applicationHost/webLimits")

      webLimitsSection("connectionTimeout") = TimeSpan.Parse("00:01:00")
      webLimitsSection("dynamicIdleThreshold") = 150
      webLimitsSection("headerWaitTimeout") = TimeSpan.Parse("00:00:30")
      webLimitsSection("minBytesPerSecond") = 500

      serverManager.CommitChanges()
   End Sub

End Module