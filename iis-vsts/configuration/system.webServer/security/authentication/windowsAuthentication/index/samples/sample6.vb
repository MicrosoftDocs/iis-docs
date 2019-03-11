Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim anonymousAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/anonymousAuthentication", "Contoso")
      anonymousAuthenticationSection("enabled") = False

      Dim windowsAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/windowsAuthentication", "Contoso")
      windowsAuthenticationSection("enabled") = True

      serverManager.CommitChanges()
   End Sub
End Module