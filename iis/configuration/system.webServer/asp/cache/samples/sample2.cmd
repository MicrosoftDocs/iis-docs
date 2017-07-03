appcmd.exe set config -section:system.webServer/asp /cache.diskTemplateCacheDirectory:"%SystemDrive%\inetpub\temp\ASP Compiled Templates" /commit:apphost
appcmd.exe set config -section:system.webServer/asp /cache.maxDiskTemplateCacheFiles:"4000" /commit:apphost
appcmd.exe set config -section:system.webServer/asp /cache.scriptFileCacheSize:"1000" /commit:apphost
appcmd.exe set config -section:system.webServer/asp /cache.scriptEngineCacheMax:"500" /commit:apphost