Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim authoringSection As ConfigurationSection = config.GetSection("system.webServer/webdav/authoring", "Default Web Site")

      Dim fileSystemElement As ConfigurationElement = authoringSection.GetChildElement("fileSystem")
      fileSystemElement("allowHiddenFiles") = True
      fileSystemElement("hideChildVirtualDirectories") = True

      serverManager.CommitChanges()
   End Sub
End Module