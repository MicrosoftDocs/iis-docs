Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim aspSection As ConfigurationSection = config.GetSection("system.webServer/asp", "Default Web Site")

      Dim sessionElement As ConfigurationElement = aspSection.GetChildElement("session")
      sessionElement("allowSessionState") = True
      sessionElement("max") = 1000
      sessionElement("timeout") = TimeSpan.Parse("00:10:00")

      serverManager.CommitChanges()
   End Sub

End Module