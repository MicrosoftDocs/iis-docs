Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set digestAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/digestAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
digestAuthenticationSection.Properties.Item("enabled").Value = True

adminManager.CommitChanges()