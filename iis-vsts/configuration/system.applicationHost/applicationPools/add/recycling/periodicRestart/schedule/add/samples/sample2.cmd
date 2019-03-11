appcmd.exe set config -section:system.applicationHost/applicationPools /+"[name='Contoso']" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /+"[name='Contoso'].recycling.periodicRestart.schedule.[value='03:00:00']" /commit:apphost