Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration

      Dim authorizationSection As ConfigurationSection = config.GetSection("system.webServer/management/authorization")
      Dim providersCollection As ConfigurationElementCollection = authorizationSection.GetCollection("providers")
      Dim addElement As ConfigurationElement = providersCollection.CreateElement("add")
      addElement("name") = "ContosoAuthorizationProvider"
      addElement("type") = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
      providersCollection.Add(addElement)
      authorizationSection("defaultProvider") = "ContosoAuthorizationProvider"

      serverManager.CommitChanges()
   End Sub

End Module