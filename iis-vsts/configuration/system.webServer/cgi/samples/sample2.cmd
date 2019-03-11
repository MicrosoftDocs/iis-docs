appcmd.exe set config "Default Web Site" -section:system.webServer/cgi /createCGIWithNewConsole:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/cgi /createProcessAsUser:"False" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/cgi /timeout:"00:20:00" /commit:apphost