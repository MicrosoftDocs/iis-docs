Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")

      Dim verbsElement As ConfigurationElement = requestFilteringSection.GetChildElement("verbs")
      verbsElement("applyToWebDAV") = False
      Dim verbsCollection As ConfigurationElementCollection = verbsElement.GetCollection

      Dim addElement As ConfigurationElement = verbsCollection.CreateElement("add")
      addElement("verb") = "PUT"
      addElement("allowed") = False
      verbsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module