Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set anonymousAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/anonymousAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
anonymousAuthenticationSection.Properties.Item("enabled").Value = False

Set windowsAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/windowsAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso")
windowsAuthenticationSection.Properties.Item("enabled").Value = True

adminManager.CommitChanges()