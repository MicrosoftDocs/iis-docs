Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim aspSection As ConfigurationSection = config.GetSection("system.webServer/asp")

      Dim limitsElement As ConfigurationElement = aspSection.GetChildElement("limits")
      limitsElement("scriptTimeout") = TimeSpan.Parse("00:02:00")
      limitsElement("queueConnectionTestTime") = TimeSpan.Parse("00:00:05")
      limitsElement("requestQueueMax") = 1000

      serverManager.CommitChanges()
   End Sub

End Module