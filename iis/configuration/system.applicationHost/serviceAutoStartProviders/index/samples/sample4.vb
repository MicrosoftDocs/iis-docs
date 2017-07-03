Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim serviceAutoStartProvidersSection As ConfigurationSection = config.GetSection("system.applicationHost/serviceAutoStartProviders")
      Dim serviceAutoStartProvidersCollection As ConfigurationElementCollection = serviceAutoStartProvidersSection.GetCollection

      Dim addElement As ConfigurationElement = serviceAutoStartProvidersCollection.CreateElement("add")
      addElement("name") = "MyAutostartProvider"
      addElement("type") = "MyAutostartProvider, MyAutostartProvider, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
      serviceAutoStartProvidersCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module