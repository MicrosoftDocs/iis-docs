Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim isapiCgiRestrictionSection As ConfigurationSection = config.GetSection("system.webServer/security/isapiCgiRestriction")
      Dim isapiCgiRestrictionCollection As ConfigurationElementCollection = isapiCgiRestrictionSection.GetCollection

      Dim addElement As ConfigurationElement = isapiCgiRestrictionCollection.CreateElement("add")
      addElement("path") = "C:\Inetpub\www.contoso.com\wwwroot\isapi\custom.dll"
      addElement("allowed") = True
      addElement("groupId") = "ContosoGroup"
      addElement("description") = "Contoso Extension"
      isapiCgiRestrictionCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module