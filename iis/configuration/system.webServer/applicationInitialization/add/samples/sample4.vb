Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Module Sample
     
     Sub Main()
         Dim serverManager As ServerManager = New ServerManager
         Dim config As Configuration = serverManager.GetApplicationHostConfiguration
         Dim applicationInitializationSection As ConfigurationSection = config.GetSection("system.webServer/applicationInitialization", "Default Web Site")
         applicationInitializationSection("remapManagedRequestsTo") = "HelloJoe.htm"
         applicationInitializationSection("skipManagedModules") = true
         applicationInitializationSection("doAppInitAfterRestart") = true
         Dim applicationInitializationCollection As ConfigurationElementCollection = applicationInitializationSection.GetCollection
         Dim addElement As ConfigurationElement = applicationInitializationCollection.CreateElement("add")
         addElement("initializationPage") = "JoesSite.htm"
         addElement("hostName") = "JoesHost"
         applicationInitializationCollection.Add(addElement)
         serverManager.CommitChanges
     End Sub
 End Module