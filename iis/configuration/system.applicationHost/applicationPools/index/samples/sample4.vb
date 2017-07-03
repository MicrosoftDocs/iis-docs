Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim applicationPoolsSection As ConfigurationSection = config.GetSection("system.applicationHost/applicationPools")
      Dim applicationPoolsCollection As ConfigurationElementCollection = applicationPoolsSection.GetCollection
      Dim addElement As ConfigurationElement = applicationPoolsCollection.CreateElement("add")
      addElement("name") = "Contoso"
      addElement("autoStart") = True
      addElement("managedPipelineMode") = "Integrated"
      applicationPoolsCollection.Add(addElement)
      serverManager.CommitChanges()
   End Sub
End Module