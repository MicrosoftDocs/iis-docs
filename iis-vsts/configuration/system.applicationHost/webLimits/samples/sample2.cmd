appcmd.exe set config -section:system.applicationHost/webLimits /connectionTimeout:"00:01:00" /commit:apphost
appcmd.exe set config -section:system.applicationHost/webLimits /dynamicIdleThreshold:"150" /commit:apphost
appcmd.exe set config -section:system.applicationHost/webLimits /headerWaitTimeout:"00:00:30" /commit:apphost
appcmd.exe set config -section:system.applicationHost/webLimits /minBytesPerSecond:"500" /commit:apphost