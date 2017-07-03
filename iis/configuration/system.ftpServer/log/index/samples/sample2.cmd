appcmd.exe set config -section:system.ftpServer/log /centralLogFileMode:"Central" /commit:apphost

appcmd.exe set config -section:system.ftpServer/log /centralLogFile.enabled:"True" /commit:apphost