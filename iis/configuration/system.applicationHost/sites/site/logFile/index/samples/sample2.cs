appcmd.exe set config -section:system.applicationHost/sites /[name='Contoso'].logFile.logFormat:"W3C" 
appcmd.exe set config -section:system.applicationHost/sites /[name='Contoso'].logFile.period:"Daily" 
appcmd.exe set config -section:system.applicationHost/sites /[name='Contoso'].logFile.localTimeRollover:"True" 
appcmd.exe set config -section:system.applicationHost/sites /[name='Contoso'].logFile.enabled:"True" /commit:apphost