Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim httpCompressionSection As ConfigurationSection = config.GetSection("system.webServer/httpCompression")
      Dim httpCompressionCollection As ConfigurationElementCollection = httpCompressionSection.GetCollection

      Dim schemeElement As ConfigurationElement = httpCompressionCollection.CreateElement("scheme")
      schemeElement("name") = "deflate"
      schemeElement("doStaticCompression") = True
      schemeElement("doDynamicCompression") = True
      schemeElement("dll") = "%Windir%\system32\inetsrv\gzip.dll"
      httpCompressionCollection.Add(schemeElement)

      serverManager.CommitChanges()
   End Sub

End Module