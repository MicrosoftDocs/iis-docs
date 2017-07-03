appcmd.exe set config "Contoso" -section:system.webServer/security/authentication/windowsAuthentication /enabled:"True" /commit:apphost

appcmd.exe set config "Contoso" -section:system.webServer/security/authentication/windowsAuthentication /-"providers.[value='Negotiate']" /commit:apphost