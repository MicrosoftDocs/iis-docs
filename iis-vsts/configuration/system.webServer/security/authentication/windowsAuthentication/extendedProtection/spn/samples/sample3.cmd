appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/windowsAuthentication /enabled:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/windowsAuthentication /extendedProtection.tokenChecking:"Allow" /extendedProtection.flags:"None" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/windowsAuthentication /+"extendedProtection.[name='HTTP/www.contoso.com']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/windowsAuthentication /+"extendedProtection.[name='HTTP/contoso.com']" /commit:apphost