appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.security.authentication.anonymousAuthentication.enabled:"TRUE" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.security.authentication.anonymousAuthentication.password:"PW" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.security.authentication.anonymousAuthentication.userName:"AUSR" /commit:apphost