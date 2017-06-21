Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")

      Dim hiddenSegmentsElement As ConfigurationElement = requestFilteringSection.GetChildElement("hiddenSegments")
      hiddenSegmentsElement("applyToWebDAV") = False
      Dim hiddenSegmentsCollection As ConfigurationElementCollection = hiddenSegmentsElement.GetCollection

      Dim addElement As ConfigurationElement = hiddenSegmentsCollection.CreateElement("add")
      addElement("segment") = "_private"
      hiddenSegmentsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module