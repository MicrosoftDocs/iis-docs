Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
    Sub Main()
        Dim serverManager As ServerManager = New ServerManager
        Dim config As Configuration = serverManager.GetApplicationHostConfiguration

        Dim basicAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/basicAuthentication", "Contoso")
        basicAuthenticationSection("enabled") = True

        serverManager.CommitChanges()
    End Sub
End Module