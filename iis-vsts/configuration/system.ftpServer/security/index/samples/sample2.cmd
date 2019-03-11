appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/authorization /+"[accessType='Allow',roles='administrators',permissions='Read, Write']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/authorization /+"[accessType='Deny',users='guest',permissions='Read, Write']" /commit:apphost