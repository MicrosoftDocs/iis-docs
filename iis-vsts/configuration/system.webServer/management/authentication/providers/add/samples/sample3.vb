Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration

      Dim authenticationSection As ConfigurationSection = config.GetSection("system.webServer/management/authentication")
      Dim providersCollection As ConfigurationElementCollection = authenticationSection.GetCollection("providers")
      Dim addElement As ConfigurationElement = providersCollection.CreateElement("add")
      addElement("name") = "ContosoAuthenticationProvider"
      addElement("type") = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
      providersCollection.Add(addElement)
      authenticationSection("defaultProvider") = "ContosoAuthenticationProvider"

      serverManager.CommitChanges()
   End Sub

End Module