appcmd.exe set config -section:system.applicationHost/sites /[name='Default Web Site'].traceFailedRequestsLogging.enabled:"True" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='Default Web Site'].traceFailedRequestsLogging.directory:"%SystemDrive%\inetpub\logs\FailedReqLogFiles" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='Default Web Site'].traceFailedRequestsLogging.maxLogFiles:"50" /commit:apphost