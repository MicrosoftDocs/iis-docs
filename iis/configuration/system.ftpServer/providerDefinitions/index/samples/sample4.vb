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

      Dim activationCollection As ConfigurationElementCollection = providerDefinitionsSection.GetCollection("activation")
      Dim providerDataElement As ConfigurationElement = activationCollection.CreateElement("providerData")
      providerDataElement("name") = "FtpXmlAuthentication"

      Dim providerDataCollection As ConfigurationElementCollection = providerDataElement.GetCollection
      Dim addElement1 As ConfigurationElement = providerDataCollection.CreateElement("add")
      addElement1("key") = "xmlFileName"
      addElement1("value") = "C:\Inetpub\wwwroot\App_Data\Users.xml"
      providerDataCollection.Add(addElement1)
      activationCollection.Add(providerDataElement)

      serverManager.CommitChanges()
   End Sub
End Module