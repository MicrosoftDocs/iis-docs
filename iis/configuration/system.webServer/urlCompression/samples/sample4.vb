Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")

      Dim urlCompressionSection As ConfigurationSection = config.GetSection("system.webServer/urlCompression")
      urlCompressionSection("doStaticCompression") = True
      urlCompressionSection("doDynamicCompression") = False

      serverManager.CommitChanges()
   End Sub

End Module