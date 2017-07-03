Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim httpProtocolSection As ConfigurationSection = config.GetSection("system.webServer/httpProtocol")
      Dim redirectHeadersCollection As ConfigurationElementCollection = httpProtocolSection.GetCollection("redirectHeaders")

      Dim addElement As ConfigurationElement = redirectHeadersCollection.CreateElement("add")
      addElement("name") = "X-Custom-Redirect-Header"
      addElement("value") = "MyRedirectValue"
      redirectHeadersCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module