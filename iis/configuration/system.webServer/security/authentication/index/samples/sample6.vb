Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set anonymousAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/anonymousAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
anonymousAuthenticationSection.Properties.Item("enabled").Value = False

Set basicAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/basicAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
basicAuthenticationSection.Properties.Item("enabled").Value = True

Set windowsAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/windowsAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
windowsAuthenticationSection.Properties.Item("enabled").Value = True

adminManager.CommitChanges()