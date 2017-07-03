Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim providerDefinitionsSection As ConfigurationSection = config.GetSection("system.ftpServer/providerDefinitions")
      Dim providerDefinitionsCollection As ConfigurationElementCollection = providerDefinitionsSection.GetCollection

      Dim addElement As ConfigurationElement = providerDefinitionsCollection.CreateElement("add")
      addElement("name") = "FtpXmlAuthentication"
      addElement("type") = "FtpXmlAuthentication, FtpXmlAuthentication, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
      providerDefinitionsCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module