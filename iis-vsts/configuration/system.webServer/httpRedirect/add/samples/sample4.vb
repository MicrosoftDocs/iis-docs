Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")

      Dim httpRedirectSection As ConfigurationSection = config.GetSection("system.webServer/httpRedirect")
      httpRedirectSection("enabled") = True
      httpRedirectSection("exactDestination") = True
      httpRedirectSection("httpResponseStatus") = "Found"

      Dim httpRedirectCollection As ConfigurationElementCollection = httpRedirectSection.GetCollection
      Dim addElement As ConfigurationElement = httpRedirectCollection.CreateElement("add")
      addElement("wildcard") = "*.asp"
      addElement("destination") = "/default.htm"
      httpRedirectCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module