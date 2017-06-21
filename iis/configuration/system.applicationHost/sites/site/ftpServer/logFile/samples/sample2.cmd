appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.logFile.directory:"C:\logs\LogFiles" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.logFile.period:"Daily" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.logFile.enabled:"True" /commit:apphost