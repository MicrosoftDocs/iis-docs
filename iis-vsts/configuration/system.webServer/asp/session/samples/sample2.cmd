appcmd.exe set config "Default Web Site" -section:system.webServer/asp /session.allowSessionState:"True" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/asp /session.max:"1000" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/asp /session.timeout:"00:10:00" /commit:apphost