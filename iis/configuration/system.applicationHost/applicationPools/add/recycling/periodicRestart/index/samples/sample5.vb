Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim applicationPoolsSection As ConfigurationSection = config.GetSection("system.applicationHost/applicationPools")
      Dim applicationPoolsCollection As ConfigurationElementCollection = applicationPoolsSection.GetCollection
      Dim addElement As ConfigurationElement = applicationPoolsCollection.CreateElement("add")
      addElement("name") = "Contoso"
      Dim recyclingElement As ConfigurationElement = addElement.GetChildElement("recycling")
      Dim periodicRestartElement As ConfigurationElement = recyclingElement.GetChildElement("periodicRestart")
      Dim scheduleCollection As ConfigurationElementCollection = periodicRestartElement.GetCollection("schedule")
      Dim addElement1 As ConfigurationElement = scheduleCollection.CreateElement("add")
      addElement1("value") = TimeSpan.Parse("03:00:00")
      scheduleCollection.Add(addElement1)
      applicationPoolsCollection.Add(addElement)
      serverManager.CommitChanges()
   End Sub
End Module