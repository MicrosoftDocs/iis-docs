Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim staticContentSection As ConfigurationSection = config.GetSection("system.webServer/staticContent")
      Dim staticContentCollection As ConfigurationElementCollection = staticContentSection.GetCollection

      Dim mimeMapElement As ConfigurationElement = staticContentCollection.CreateElement("mimeMap")
      mimeMapElement("fileExtension") = "syx"
      mimeMapElement("mimeType") = "application/octet-stream"
      staticContentCollection.Add(mimeMapElement)

      Dim mimeMapElement1 As ConfigurationElement = staticContentCollection.CreateElement("mimeMap")
      mimeMapElement1("fileExtension") = "tab"
      mimeMapElement1("mimeType") = "text/plain"
      staticContentCollection.Add(mimeMapElement1)

      serverManager.CommitChanges()
   End Sub

End Module