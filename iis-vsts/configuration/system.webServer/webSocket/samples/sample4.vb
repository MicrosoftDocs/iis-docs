Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim webSocketSection As ConfigurationSection = config.GetSection("system.webServer/webSocket", "Default Web Site")
      webSocketSection("enabled") = true
      webSocketSection("receiveBufferLimit") = 4194304
      webSocketSection("pingInterval") = TimeSpan.Parse("00:00:10")
      serverManager.CommitChanges
   End Sub
End Module