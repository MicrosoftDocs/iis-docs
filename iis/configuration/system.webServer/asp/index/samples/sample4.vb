Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim aspSection As ConfigurationSection = config.GetSection("system.webServer/asp", "Contoso")
      aspSection("enableParentPaths") = False
      aspSection("bufferingOn") = True
      Dim sessionElement As ConfigurationElement = aspSection.GetChildElement("session")
      sessionElement("allowSessionState") = True
      serverManager.CommitChanges()
   End Sub
End Module