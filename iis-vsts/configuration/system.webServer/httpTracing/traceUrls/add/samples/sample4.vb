Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim httpTracingSection As ConfigurationSection = config.GetSection("system.webServer/httpTracing", "Contoso")

      Dim traceUrlsCollection As ConfigurationElementCollection = httpTracingSection.GetCollection("traceUrls")
      Dim addElement As ConfigurationElement = traceUrlsCollection.CreateElement("add")
      addElement("value") = "/iisstart.htm"
      traceUrlsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module