appcmd.exe set config "Default Web Site" -section:system.webServer/serverRuntime /enabled:"True" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/serverRuntime /frequentHitThreshold:"5" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/serverRuntime /frequentHitTimePeriod:"00:00:20" /commit:apphost