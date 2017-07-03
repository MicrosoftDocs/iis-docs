Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim aspSection As ConfigurationSection = config.GetSection("system.webServer/asp", "Default Web Site")

      Dim comPlusElement As ConfigurationElement = aspSection.GetChildElement("comPlus")
      comPlusElement("trackThreadingModel") = True
      comPlusElement("executeInMta") = True

      serverManager.CommitChanges()
   End Sub

End Module