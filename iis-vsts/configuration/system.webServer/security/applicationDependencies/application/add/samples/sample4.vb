Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim applicationDependenciesSection As ConfigurationSection = config.GetSection("system.webServer/security/applicationDependencies", "Default Web Site")

      Dim applicationDependenciesCollection As ConfigurationElementCollection = applicationDependenciesSection.GetCollection
      Dim applicationElement As ConfigurationElement = applicationDependenciesCollection.CreateElement("application")
      applicationElement("name") = "My Custom Application"
      applicationElement("groupId") = "MyCustomGroup"

      Dim applicationCollection As ConfigurationElementCollection = applicationElement.GetCollection
      Dim addElement As ConfigurationElement = applicationCollection.CreateElement("add")
      addElement("groupId") = "ASP"
      applicationCollection.Add(addElement)
      applicationDependenciesCollection.Add(applicationElement)

      serverManager.CommitChanges()
   End Sub

End Module