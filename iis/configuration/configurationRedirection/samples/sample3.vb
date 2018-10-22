Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetRedirectionConfiguration
      Dim redirectionSection As ConfigurationSection = config.GetSection("configurationRedirection")
      redirectionSection.Attributes("enabled").Value = True
      redirectionSection.Attributes("path").Value = "\\ServerName\ShareName"
      redirectionSection.Attributes("userName").Value = "MyUser"
      redirectionSection.Attributes("password").Value = "P@ssw0rd"
      serverManager.CommitChanges()
   End Sub
End Module