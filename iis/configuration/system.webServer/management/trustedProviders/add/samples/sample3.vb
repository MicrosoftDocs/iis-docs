Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration

      Dim trustedProvidersSection As ConfigurationSection = config.GetSection("system.webServer/management/trustedProviders")
      Dim trustedProvidersCollection As ConfigurationElementCollection = trustedProvidersSection.GetCollection
      Dim addElement As ConfigurationElement = trustedProvidersCollection.CreateElement("add")
      addElement("type") = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
      trustedProvidersCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module