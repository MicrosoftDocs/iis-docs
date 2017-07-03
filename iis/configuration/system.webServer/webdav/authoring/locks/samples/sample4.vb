Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim authoringSection As ConfigurationSection = config.GetSection("system.webServer/webdav/authoring", "Default Web Site")

      Dim locksElement As ConfigurationElement = authoringSection.GetChildElement("locks")
      locksElement("enabled") = True
      locksElement("lockStore") = "webdav_simple_lock"
      locksElement("requireLockForWriting") = False

      serverManager.CommitChanges()
   End Sub
End Module