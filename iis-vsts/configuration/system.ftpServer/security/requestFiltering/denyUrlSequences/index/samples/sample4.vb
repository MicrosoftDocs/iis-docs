Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.ftpServer/security/requestFiltering", "Default Web Site")
      Dim denyUrlSequencesCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("denyUrlSequences")

      Dim addElement As ConfigurationElement = denyUrlSequencesCollection.CreateElement("add")
      addElement("sequence") = "bin"
      denyUrlSequencesCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module