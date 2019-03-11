appcmd.exe set config -section:system.applicationHost/sites /[name='MyFTPSite'].ftpServer.security.customAuthorization.provider.name:"MyProvider" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='MyFTPSite'].ftpServer.security.customAuthorization.provider.enabled:"True" /commit:apphost