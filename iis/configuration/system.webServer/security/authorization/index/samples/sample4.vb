Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Contoso")
      Dim authorizationSection As ConfigurationSection = config.GetSection("system.webServer/security/authorization")
      Dim authorizationCollection As ConfigurationElementCollection = authorizationSection.GetCollection
      Dim addElement As ConfigurationElement = authorizationCollection.CreateElement("add")
      addElement("accessType") = "Allow"
      addElement("roles") = "administrators"
      authorizationCollection.Add(addElement)
      serverManager.CommitChanges()
   End Sub
End Module