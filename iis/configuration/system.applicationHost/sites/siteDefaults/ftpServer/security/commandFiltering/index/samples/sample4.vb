Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim sitesSection As ConfigurationSection = config.GetSection("system.applicationHost/sites")
      Dim siteDefaultsElement As ConfigurationElement = sitesSection.GetChildElement("siteDefaults")
      Dim ftpServerElement As ConfigurationElement = siteDefaultsElement.GetChildElement("ftpServer")

      Dim securityElement As ConfigurationElement = ftpServerElement.GetChildElement("security")
      Dim commandFilteringElement As ConfigurationElement = securityElement.GetChildElement("commandFiltering")
      Dim commandFilteringCollection As ConfigurationElementCollection = commandFilteringElement.GetCollection
      Dim addElement As ConfigurationElement = commandFilteringCollection.CreateElement("add")
         addElement("command") = "SYST"
         addElement("allowed") = False
         commandFilteringCollection.Add(addElement)
 
      serverManager.CommitChanges()
   End Sub

End Module