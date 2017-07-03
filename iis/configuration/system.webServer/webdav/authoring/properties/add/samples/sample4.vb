Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim authoringSection As ConfigurationSection = config.GetSection("system.webServer/webdav/authoring", "Default Web Site")

      Dim propertiesElement As ConfigurationElement = authoringSection.GetChildElement("properties")
      propertiesElement("allowAnonymousPropfind") = False
      propertiesElement("allowInfinitePropfindDepth") = False
      propertiesElement("allowCustomProperties") = True

      Dim propertiesCollection As ConfigurationElementCollection = propertiesElement.GetCollection

      Dim addElement As ConfigurationElement = propertiesCollection.CreateElement("add")
      addElement("xmlNamespace") = "*"
      addElement("propertyStore") = "webdav_simple_prop"
      propertiesCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module