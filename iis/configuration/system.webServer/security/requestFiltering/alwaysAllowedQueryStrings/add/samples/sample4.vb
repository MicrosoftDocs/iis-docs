Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")

      Dim alwaysAllowedQueryStringsCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("alwaysAllowedQueryStrings")
      Dim addElement As ConfigurationElement = alwaysAllowedQueryStringsCollection.CreateElement("add")
      addElement("queryString") = "allowed=sequence"
      alwaysAllowedQueryStringsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module