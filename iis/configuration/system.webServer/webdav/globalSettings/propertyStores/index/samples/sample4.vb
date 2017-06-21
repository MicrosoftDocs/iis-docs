Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim globalSettingsSection As ConfigurationSection = config.GetSection("system.webServer/webdav/globalSettings")

      Dim propertyStoresCollection As ConfigurationElementCollection = globalSettingsSection.GetCollection("propertyStores")

      Dim addElement As ConfigurationElement = propertyStoresCollection.CreateElement("add")
      addElement("name") = "webdav_simple_prop"
      addElement("image") = "%windir%\system32\inetsrv\webdav_simple_prop.dll"
      propertyStoresCollection.Add(addElement)

      Dim lockStoresCollection As ConfigurationElementCollection = globalSettingsSection.GetCollection("lockStores")

      Dim addElement1 As ConfigurationElement = lockStoresCollection.CreateElement("add")
      addElement1("name") = "webdav_simple_lock"
      addElement1("image") = "%windir%\system32\inetsrv\webdav_simple_lock.dll"
      lockStoresCollection.Add(addElement1)

      serverManager.CommitChanges()
   End Sub
End Module