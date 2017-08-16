appcmd.exe set config  -section:system.applicationHost/sites /siteDefaults.hsts.enabled:"True" /commit:apphost
appcmd.exe set config  -section:system.applicationHost/sites /siteDefaults.hsts.max-age:"31536000" /commit:apphost
appcmd.exe set config  -section:system.applicationHost/sites /siteDefaults.hsts.includeSubDomains:"True" /commit:apphost
appcmd.exe set config  -section:system.applicationHost/sites /siteDefaults.hsts.redirectHttpToHttps:"True" /commit:apphost