Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set basicAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/basicAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
basicAuthenticationSection.Properties.Item("enabled").Value = True

adminManager.CommitChanges()