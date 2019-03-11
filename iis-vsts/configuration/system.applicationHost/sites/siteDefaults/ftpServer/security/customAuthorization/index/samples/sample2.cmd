appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.customAuthorization.provider.name:"MyCustomProvider" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.customAuthorization.provider.enabled:"True" /commit:apphost