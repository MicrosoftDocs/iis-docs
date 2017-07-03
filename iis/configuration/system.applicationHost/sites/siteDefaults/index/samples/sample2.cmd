appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.limits.connectionTimeout:"00:02:00" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.logFile.enabled:"True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.logFile.logFormat:"W3C" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.logFile.directory:"%SystemDrive%\inetpub\logs\LogFiles" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.traceFailedRequestsLogging.enabled:"True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.traceFailedRequestsLogging.directory:"%SystemDrive%\inetpub\logs\FailedReqLogFiles" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.traceFailedRequestsLogging.maxLogFiles:"20" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.bindings.[protocol='http',bindingInformation='*:8080:contoso.com'].bindingInformation:"127.0.0.1:8080:" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.serverAutoStart:"True" /commit:apphost