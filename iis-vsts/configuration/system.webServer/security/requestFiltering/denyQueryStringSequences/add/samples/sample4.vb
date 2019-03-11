Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")

      Dim denyQueryStringSequencesCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("denyQueryStringSequences")
      Dim addElement As ConfigurationElement = denyQueryStringSequencesCollection.CreateElement("add")
      addElement("sequence") = "bad_querystring_sequence"
      denyQueryStringSequencesCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module