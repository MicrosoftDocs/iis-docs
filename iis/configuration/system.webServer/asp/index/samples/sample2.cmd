appcmd.exe set config "Contoso" -section:system.webServer/asp /enableParentPaths:"False" /commit:apphost
appcmd.exe set config "Contoso" -section:system.webServer/asp /bufferingOn:"True" /commit:apphost
appcmd.exe set config "Contoso" -section:system.webServer/asp /session.allowSessionState:"True" /commit:apphost