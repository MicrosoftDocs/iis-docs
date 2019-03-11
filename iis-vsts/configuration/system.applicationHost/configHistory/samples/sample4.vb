Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim configHistorySection As ConfigurationSection = config.GetSection("system.applicationHost/configHistory")
      configHistorySection("enabled") = True
      configHistorySection("path") = "%SystemDrive%\inetpub\history"
      configHistorySection("maxHistories") = 50
      configHistorySection("period") = TimeSpan.Parse("00:05:00")

      serverManager.CommitChanges()
   End Sub

End Module