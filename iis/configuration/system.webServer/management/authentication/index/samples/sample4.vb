Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration

      Dim authenticationSection As ConfigurationSection = config.GetSection("system.webServer/management/authentication")
      Dim credentialsCollection As ConfigurationElementCollection = authenticationSection.GetCollection("credentials")
      Dim addElement As ConfigurationElement = credentialsCollection.CreateElement("add")
      addElement("name") = "ContosoUser"
      addElement("password") = "P@ssw0rd"
      credentialsCollection.Add(addElement)
      addElement("enabled") = True
      serverManager.CommitChanges()
   End Sub

End Module