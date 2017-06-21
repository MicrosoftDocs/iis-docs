appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.fileHandling.keepPartialUploads:"True" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.fileHandling.allowReplaceOnRename:"True" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.fileHandling.allowReadUploadsInProgress:"False" /commit:apphost