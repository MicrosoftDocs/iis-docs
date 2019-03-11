Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Contoso")
      Dim traceFailedRequestsSection As ConfigurationSection = config.GetSection("system.webServer/tracing/traceFailedRequests")
      Dim traceFailedRequestsCollection As ConfigurationElementCollection = traceFailedRequestsSection.GetCollection

      Dim addElement As ConfigurationElement = traceFailedRequestsCollection.CreateElement("add")
      addElement("path") = "*.aspx"
      Dim traceAreasCollection As ConfigurationElementCollection = addElement.GetCollection("traceAreas")
      Dim addElement1 As ConfigurationElement = traceAreasCollection.CreateElement("add")
      addElement1("provider") = "ASPNET"
      addElement1("areas") = "Infrastructure,Module,Page,AppServices"
      addElement1("verbosity") = "Verbose"
      traceAreasCollection.Add(addElement1)

      Dim failureDefinitionsElement As ConfigurationElement = addElement.GetChildElement("failureDefinitions")
      failureDefinitionsElement("statusCodes") = "500"
      traceFailedRequestsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module