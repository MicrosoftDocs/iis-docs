Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")

      Dim alwaysAllowedUrlsCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("alwaysAllowedUrls")
      Dim addElement As ConfigurationElement = alwaysAllowedUrlsCollection.CreateElement("add")
      addElement("url") = "/allowed_url.aspx"
      alwaysAllowedUrlsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module