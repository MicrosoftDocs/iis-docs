Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")

      Dim httpProtocolSection As ConfigurationSection = config.GetSection("system.webServer/httpProtocol")
      httpProtocolSection("allowKeepAlive") = True

      serverManager.CommitChanges()
   End Sub

End Module