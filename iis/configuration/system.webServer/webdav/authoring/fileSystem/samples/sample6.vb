Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set fileSystemElement = authoringSection.ChildElements.Item("fileSystem")
fileSystemElement.Properties.Item("allowHiddenFiles").Value = True
fileSystemElement.Properties.Item("hideChildVirtualDirectories").Value = True

adminManager.CommitChanges()