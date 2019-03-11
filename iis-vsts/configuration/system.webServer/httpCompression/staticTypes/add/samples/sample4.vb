Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim httpCompressionSection As ConfigurationSection = config.GetSection("system.webServer/httpCompression")
      Dim staticTypesCollection As ConfigurationElementCollection = httpCompressionSection.GetCollection("staticTypes")

      Dim addElement As ConfigurationElement = staticTypesCollection.CreateElement("add")
      addElement("mimeType") = "application/msword"
      addElement("enabled") = True
      staticTypesCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = staticTypesCollection.CreateElement("add")
      addElement1("mimeType") = "application/vnd.ms-powerpoint"
      addElement1("enabled") = True
      staticTypesCollection.Add(addElement1)

      Dim addElement2 As ConfigurationElement = staticTypesCollection.CreateElement("add")
      addElement2("mimeType") = "application/vnd.ms-excel"
      addElement2("enabled") = True
      staticTypesCollection.Add(addElement2)

      serverManager.CommitChanges()
   End Sub

End Module