Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim httpErrorsSection As ConfigurationSection = config.GetSection("system.webServer/httpErrors")
      Dim httpErrorsCollection As ConfigurationElementCollection = httpErrorsSection.GetCollection

      Dim errorElement As ConfigurationElement = httpErrorsCollection.CreateElement("error")
      errorElement("statusCode") = 404
      errorElement("subStatusCode") = 5
      errorElement("prefixLanguageFilePath") = "%SystemDrive%\inetpub\custerr"
      errorElement("path") = "404.5.htm"
      httpErrorsCollection.Add(errorElement)

      serverManager.CommitChanges()
   End Sub
End Module