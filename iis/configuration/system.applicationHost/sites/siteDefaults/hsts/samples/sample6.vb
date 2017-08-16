Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")

Set hstsElement  = siteDefaultsElement.ChildElements.Item("hsts")
hstsElement.Properties.Item("enabled").Value = True
hstsElement.Properties.Item("max-age").Value = 31536000
hstsElement.Properties.Item("includeSubDomains").Value = True
hstsElement.Properties.Item("redirectHttpToHttps").Value = True

adminManager.CommitChanges()