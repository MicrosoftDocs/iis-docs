Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set firewallSupportElement = ftpServerElement.ChildElements.Item("firewallSupport")
   firewallSupportElement.Properties.Item("externalIp4Address").Value = "169.254.10.10"

adminManager.CommitChanges()