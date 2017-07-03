appcmd.exe set config -section:system.applicationHost/log /centralLogFileMode:"CentralW3C" /commit:apphost

appcmd.exe set config -section:system.applicationHost/log /centralW3CLogFile.period:"Daily" /commit:apphost