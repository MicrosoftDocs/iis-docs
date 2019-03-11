Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetAdministrationConfiguration
      Dim modulesSection As ConfigurationSection = config.GetSection("modules")

      Dim modulesCollection As ConfigurationElementCollection = modulesSection.GetCollection
      Dim addElement As ConfigurationElement = modulesCollection.CreateElement("add")
      addElement("name") = "ContosoProvider"
      modulesCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module