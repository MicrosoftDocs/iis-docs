Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Contoso")
      Dim modulesSection As ConfigurationSection = config.GetSection("system.webServer/modules")
      Dim modulesCollection As ConfigurationElementCollection = modulesSection.GetCollection

      Dim addElement As ConfigurationElement = modulesCollection.CreateElement("add")
      addElement("name") = "CartHeader"
      addElement("type") = "Contoso.ShoppingCart.Header"
      addElement("preCondition") = "managedHandler"
      modulesCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub
End Module