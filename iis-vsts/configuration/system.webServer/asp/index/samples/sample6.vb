Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST/Contoso")
aspSection.Properties.Item("enableParentPaths").Value = False
aspSection.Properties.Item("bufferingOn").Value = True
Set sessionElement = aspSection.ChildElements.Item("session")
sessionElement.Properties.Item("allowSessionState").Value = True

adminManager.CommitChanges()