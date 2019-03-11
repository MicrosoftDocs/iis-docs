Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")

      Dim staticContentSection As ConfigurationSection = config.GetSection("system.webServer/staticContent")
      staticContentSection("defaultDocFooter") = "The information in this web site is copyrighted."
      staticContentSection("enableDocFooter") = True

      serverManager.CommitChanges()
   End Sub

End Module