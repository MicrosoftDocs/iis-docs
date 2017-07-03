Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")
      Dim denyUrlSequencesCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("denyUrlSequences")

      Dim addElement As ConfigurationElement = denyUrlSequencesCollection.CreateElement("add")
      addElement("sequence") = ".."
      denyUrlSequencesCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = denyUrlSequencesCollection.CreateElement("add")
      addElement1("sequence") = ":"
      denyUrlSequencesCollection.Add(addElement1)

      Dim addElement2 As ConfigurationElement = denyUrlSequencesCollection.CreateElement("add")
      addElement2("sequence") = "\"
      denyUrlSequencesCollection.Add(addElement2)

      serverManager.CommitChanges()
   End Sub

End Module