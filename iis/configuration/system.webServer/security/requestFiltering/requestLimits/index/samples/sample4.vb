Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")
      Dim requestLimitsElement As ConfigurationElement = requestFilteringSection.GetChildElement("requestLimits")
      Dim headerLimitsCollection As ConfigurationElementCollection = requestLimitsElement.GetCollection("headerLimits")

      Dim addElement As ConfigurationElement = headerLimitsCollection.CreateElement("add")
      addElement("header") = "Content-type"
      addElement("sizeLimit") = 100
      headerLimitsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module