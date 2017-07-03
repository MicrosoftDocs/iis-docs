Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")
      Dim ftpServerElement As ConfigurationElement = siteDefaultsElement.GetChildElement("ftpServer")

      Dim securityElement As ConfigurationElement = ftpServerElement.GetChildElement("security")
      Dim authenticationElement As ConfigurationElement = securityElement.GetChildElement("authentication")
      Dim customAuthenticationElement As ConfigurationElement = authenticationElement.GetChildElement("customAuthentication")
      Dim providersCollection As ConfigurationElementCollection = customAuthenticationElement.GetCollection("providers")
      Dim addElement1 As ConfigurationElement = providersCollection.CreateElement("add")
         addElement1("name") = "FtpCustomAuthenticationModule"
         addElement1("enabled") = True
         providersCollection.Add(addElement1)

      serverManager.CommitChanges()
   End Sub

End Module