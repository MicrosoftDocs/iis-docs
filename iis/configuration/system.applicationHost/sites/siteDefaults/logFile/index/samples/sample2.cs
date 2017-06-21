appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.logFile.enabled:"True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.logFile.logFormat:"W3C" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.logFile.directory:"%SystemDrive%\inetpub\logs\LogFiles" /commit:apphost