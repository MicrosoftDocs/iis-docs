Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim authorizationSection As ConfigurationSection = config.GetSection("system.ftpServer/security/authorization", "Default Web Site")
      Dim authorizationCollection As ConfigurationElementCollection = authorizationSection.GetCollection

      Dim addElement As ConfigurationElement = authorizationCollection.CreateElement("add")
      addElement("accessType") = "Allow"
      addElement("roles") = "administrators"
      addElement("permissions") = "Read, Write"
      authorizationCollection.Add(addElement)

      Dim addElement1 As ConfigurationElement = authorizationCollection.CreateElement("add")
      addElement1("accessType") = "Deny"
      addElement1("users") = "guest"
      addElement1("permissions") = "Read, Write"
      authorizationCollection.Add(addElement1)

      serverManager.CommitChanges()
   End Sub
End Module