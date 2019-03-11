Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration
      Dim moduleProvidersSection As ConfigurationSection = config.GetSection("moduleProviders")

      Dim moduleProvidersCollection As ConfigurationElementCollection = moduleProvidersSection.GetCollection
      Dim addElement As ConfigurationElement = moduleProvidersCollection.CreateElement("add")
      addElement("name") = "ContosoProvider"
      addElement("type") = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
      moduleProvidersCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module