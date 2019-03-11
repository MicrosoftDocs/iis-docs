appcmd.exe set config -section:system.webServer/asp /limits.scriptTimeout:"00:02:00" /commit:apphost
appcmd.exe set config -section:system.webServer/asp /limits.queueConnectionTestTime:"00:00:05" /commit:apphost
appcmd.exe set config -section:system.webServer/asp /limits.requestQueueMax:"1000" /commit:apphost