Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim httpCompressionSection As ConfigurationSection = config.GetSection("system.webServer/httpCompression")
      Dim dynamicTypesCollection As ConfigurationElementCollection = httpCompressionSection.GetCollection("dynamicTypes")

      Dim addElement As ConfigurationElement = dynamicTypesCollection.CreateElement("add")
      addElement("mimeType") = "application/msword"
      addElement("enabled") = True
      dynamicTypesCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = dynamicTypesCollection.CreateElement("add")
      addElement1("mimeType") = "application/vnd.ms-powerpoint"
      addElement1("enabled") = True
      dynamicTypesCollection.Add(addElement1)

      Dim addElement2 As ConfigurationElement = dynamicTypesCollection.CreateElement("add")
      addElement2("mimeType") = "application/vnd.ms-excel"
      addElement2("enabled") = True
      dynamicTypesCollection.Add(addElement2)

      serverManager.CommitChanges()
   End Sub

End Module