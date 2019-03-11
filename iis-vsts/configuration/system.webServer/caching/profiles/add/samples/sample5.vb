Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim cachingSection As ConfigurationSection = config.GetSection("system.webServer/caching")
      Dim profilesCollection As ConfigurationElementCollection = cachingSection.GetCollection("profiles")
      Dim addElement As ConfigurationElement = profilesCollection.CreateElement("add")
      addElement("extension") = "asp"
      addElement("policy") = "CacheUntilChange"
      addElement("kernelCachePolicy") = "CacheUntilChange"
      profilesCollection.AddAt(0, addElement)
      serverManager.CommitChanges()
   End Sub
End Module