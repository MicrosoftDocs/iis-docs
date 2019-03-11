appcmd.exe set config "Contoso" -section:system.webServer/security/authentication/anonymousAuthentication /enabled:"False" /commit:apphost

appcmd.exe set config "Contoso" -section:system.webServer/security/authentication/basicAuthentication /enabled:"True" /commit:apphost

appcmd.exe set config "Contoso" -section:system.webServer/security/authentication/windowsAuthentication /enabled:"True" /commit:apphost