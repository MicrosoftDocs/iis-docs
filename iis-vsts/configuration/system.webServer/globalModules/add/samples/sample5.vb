Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim globalModulesSection As ConfigurationSection = config.GetSection("system.webServer/globalModules")
      Dim globalModulesCollection As ConfigurationElementCollection = globalModulesSection.GetCollection
      Dim addElement As ConfigurationElement = globalModulesCollection.CreateElement("add")
      addElement("name") = "ImageCopyrightModule"
      addElement("image") = "%windir%\system32\inetsrv\imageCopyrightModule.dll"
      globalModulesCollection.Add(addElement)
      serverManager.CommitChanges()
   End Sub
End Module