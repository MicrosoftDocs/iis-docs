Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim ipSecuritySection As ConfigurationSection = config.GetSection("system.webServer/security/ipSecurity", "Default Web Site")
      
      ipSecuritySection("enableReverseDns") = True
      
      serverManager.CommitChanges()
   End Sub

End Module