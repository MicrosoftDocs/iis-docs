Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT"
adminManager.SetMetadata "pathMapper", "AdministrationConfig"

Set trustedProvidersSection = adminManager.GetAdminSection("system.webServer/management/trustedProviders", "MACHINE/WEBROOT")
Set trustedProvidersCollection = trustedProvidersSection.Collection

Set addElement = trustedProvidersCollection.CreateNewElement("add")
addElement.Properties.Item("type").Value = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
trustedProvidersCollection.AddElement(addElement)

adminManager.CommitChanges()