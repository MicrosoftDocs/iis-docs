Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.ftpServer/security/requestFiltering", "Default Web Site")
      Dim fileExtensionsElement As ConfigurationElement = requestFilteringSection.GetChildElement("fileExtensions")
      Dim fileExtensionsCollection As ConfigurationElementCollection = fileExtensionsElement.GetCollection

      Dim addElement As ConfigurationElement = fileExtensionsCollection.CreateElement("add")
      addElement("fileExtension") = ".exe"
      addElement("allowed") = False
      fileExtensionsCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = fileExtensionsCollection.CreateElement("add")
      addElement1("fileExtension") = ".com"
      addElement1("allowed") = False
      fileExtensionsCollection.Add(addElement1)

      Dim addElement2 As ConfigurationElement = fileExtensionsCollection.CreateElement("add")
      addElement2("fileExtension") = ".cmd"
      addElement2("allowed") = False
      fileExtensionsCollection.Add(addElement2)

      Dim addElement3 As ConfigurationElement = fileExtensionsCollection.CreateElement("add")
      addElement3("fileExtension") = ".bat"
      addElement3("allowed") = False
      fileExtensionsCollection.Add(addElement3)

      serverManager.CommitChanges()
   End Sub
End Module