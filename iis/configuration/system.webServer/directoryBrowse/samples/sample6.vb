Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso"

Set directoryBrowseSection = adminManager.GetAdminSection("system.webServer/directoryBrowse", "MACHINE/WEBROOT/APPHOST/Contoso")
directoryBrowseSection.Properties.Item("enabled").Value = True
directoryBrowseSection.Properties.Item("showFlags").Value = "Date, Time, Size, Extension"

adminManager.CommitChanges()