Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set securityElement = ftpServerElement.ChildElements.Item("security")
Set sslElement = securityElement.ChildElements.Item("ssl")
   sslElement.Properties.Item("controlChannelPolicy").Value = "SslAllow"
   sslElement.Properties.Item("dataChannelPolicy").Value = "SslAllow"
   sslElement.Properties.Item("serverCertHash").Value = "57686f6120447564652c2049495320526f636b73"

adminManager.CommitChanges()