Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim listenerAdaptersSection As ConfigurationSection = config.GetSection("system.applicationHost/listenerAdapters")
      Dim listenerAdaptersCollection As ConfigurationElementCollection = listenerAdaptersSection.GetCollection

      Dim addElement As ConfigurationElement = listenerAdaptersCollection.CreateElement("add")
      addElement("name") = "gopher"
      addElement("protocolManagerDll") = "%SystemRoot%\system32\inetsrv\gophersvc.dll"
      addElement("protocolManagerDllInitFunction") = "GopherInit"
      listenerAdaptersCollection.Add(addElement)

      serverManager.CommitChanges()
   End Sub

End Module