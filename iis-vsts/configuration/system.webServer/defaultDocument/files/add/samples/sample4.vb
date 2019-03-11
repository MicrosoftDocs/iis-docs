Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Class Sample
   Shared Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Contoso")
      Dim defaultDocumentSection As ConfigurationSection = config.GetSection("system.webServer/defaultDocument")

      defaultDocumentSection("enabled") = True

      Dim filesCollection As ConfigurationElementCollection = defaultDocumentSection.GetCollection("files")
      Dim addElement As ConfigurationElement = filesCollection.CreateElement("add")
      addElement("value") = "home.html"
      filesCollection.AddAt(0, addElement)

      serverManager.CommitChanges()
   End Sub
End Class