Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim staticContentSection As ConfigurationSection = config.GetSection("system.webServer/staticContent")

      Dim clientCacheElement As ConfigurationElement = staticContentSection.GetChildElement("clientCache")
      clientCacheElement("cacheControlMode") = "UseExpires"
      clientCacheElement("httpExpires") = "Tue, 19 Jan 2038 03:14:07 GMT"

      serverManager.CommitChanges()
   End Sub

End Module