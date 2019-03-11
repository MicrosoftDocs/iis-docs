appcmd.exe set config -section:system.ftpServer/caching /credentialsCache.enabled:"True" /commit:apphost

appcmd.exe set config -section:system.ftpServer/caching /credentialsCache.flushInterval:"300" /commit:apphost