Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim authoringRulesSection As ConfigurationSection = config.GetSection("system.webServer/webdav/authoringRules", "Default Web Site")
      authoringRulesSection("allowNonMimeMapFiles") = True

      Dim authoringRulesCollection As ConfigurationElementCollection = authoringRulesSection.GetCollection

      Dim addElement As ConfigurationElement = authoringRulesCollection.CreateElement("add")
      addElement("roles") = "administrators"
      addElement("path") = "*"
      addElement("access") = "Read, Write, Source"
      authoringRulesCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module