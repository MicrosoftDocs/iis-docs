appcmd.exe set config -section:system.applicationHost/sites "/[name='Contoso'].hsts.enabled:True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites "/[name='Contoso'].hsts.max-age:31536000" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites "/[name='Contoso'].hsts.includeSubDomains:True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites "/[name='Contoso'].hsts.redirectHttpToHttps:True" /commit:apphost