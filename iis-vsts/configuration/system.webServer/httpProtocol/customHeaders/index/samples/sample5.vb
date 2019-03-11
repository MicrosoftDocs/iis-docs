Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim httpProtocolSection As ConfigurationSection = config.GetSection("system.webServer/httpProtocol")
      Dim customHeadersCollection As ConfigurationElementCollection = httpProtocolSection.GetCollection("customHeaders")

      Dim addElement As ConfigurationElement = customHeadersCollection.CreateElement("add")
      addElement("name") = "X-Custom-Name"
      addElement("value") = "MyCustomValue"
      customHeadersCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module