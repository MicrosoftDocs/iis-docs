Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")

      Dim fileExtensionsElement As ConfigurationElement = requestFilteringSection.GetChildElement("fileExtensions")
      fileExtensionsElement("applyToWebDAV") = False
      Dim fileExtensionsCollection As ConfigurationElementCollection = fileExtensionsElement.GetCollection

      Dim addElement As ConfigurationElement = fileExtensionsCollection.CreateElement("add")
      addElement("fileExtension") = "inc"
      addElement("allowed") = False
      fileExtensionsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module