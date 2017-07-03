Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")

      Dim httpRedirectSection As ConfigurationSection = config.GetSection("system.webServer/httpRedirect")
      httpRedirectSection("enabled") = True
      httpRedirectSection("destination") = "http://www.contoso.com"
      httpRedirectSection("exactDestination") = False
      httpRedirectSection("httpResponseStatus") = "Found"

      serverManager.CommitChanges()
   End Sub

End Module