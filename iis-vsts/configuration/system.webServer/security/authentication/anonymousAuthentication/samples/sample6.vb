Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set anonymousAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/anonymousAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
anonymousAuthenticationSection.Properties.Item("enabled").Value = True
anonymousAuthenticationSection.Properties.Item("userName").Value = "IUSR"
anonymousAuthenticationSection.Properties.Item("password").Value = "P@ssw0rd"

adminManager.CommitChanges()