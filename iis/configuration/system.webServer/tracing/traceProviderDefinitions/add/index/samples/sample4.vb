Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim traceProviderDefinitionsSection As ConfigurationSection = config.GetSection("system.webServer/tracing/traceProviderDefinitions")
      Dim traceProviderDefinitionsCollection As ConfigurationElementCollection = traceProviderDefinitionsSection.GetCollection

      Dim addElement As ConfigurationElement = traceProviderDefinitionsCollection.CreateElement("add")
      addElement("name") = "MyTraceProvider"
      addElement("guid") = "{00000000-0000-0000-0000-00000000000}"
      Dim areasCollection As ConfigurationElementCollection = addElement.GetCollection("areas")

      Dim addElement1 As ConfigurationElement = areasCollection.CreateElement("add")
      addElement1("name") = "ProviderAreaOne"
      addElement1("value") = 0
      areasCollection.Add(addElement1)

      Dim addElement2 As ConfigurationElement = areasCollection.CreateElement("add")
      addElement2("name") = "ProviderAreaTwo"
      addElement2("value") = 1
      areasCollection.Add(addElement2)

      traceProviderDefinitionsCollection.Add(addElement)
      serverManager.CommitChanges()
   End Sub
End Module