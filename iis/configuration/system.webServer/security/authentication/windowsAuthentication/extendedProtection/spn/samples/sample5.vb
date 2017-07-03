Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim windowsAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/windowsAuthentication", "Default Web Site")
      windowsAuthenticationSection("enabled") = True

      Dim extendedProtectionElement As ConfigurationElement = windowsAuthenticationSection.GetChildElement("extendedProtection")
      extendedProtectionElement("tokenChecking") = "Allow"
      extendedProtectionElement("flags") = "None"

      Dim extendedProtectionCollection As ConfigurationElementCollection = extendedProtectionElement.GetCollection

      Dim spnElement As ConfigurationElement = extendedProtectionCollection.CreateElement("spn")
      spnElement("name") = "HTTP/www.contoso.com"
      extendedProtectionCollection.Add(spnElement)

      Dim spnElement1 As ConfigurationElement = extendedProtectionCollection.CreateElement("spn")
      spnElement1("name") = "HTTP/contoso.com"
      extendedProtectionCollection.Add(spnElement1)

      serverManager.CommitChanges()
   End Sub
End Module