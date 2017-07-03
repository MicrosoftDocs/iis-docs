Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.ftpServer/security/requestFiltering", "Default Web Site")
      Dim hiddenSegmentsCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("hiddenSegments")

      Dim addElement As ConfigurationElement = hiddenSegmentsCollection.CreateElement("add")
      addElement("segment") = "bin"
      hiddenSegmentsCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = hiddenSegmentsCollection.CreateElement("add")
      addElement1("segment") = "App_Code"
      hiddenSegmentsCollection.Add(addElement1)

      serverManager.CommitChanges()
   End Sub
End Module