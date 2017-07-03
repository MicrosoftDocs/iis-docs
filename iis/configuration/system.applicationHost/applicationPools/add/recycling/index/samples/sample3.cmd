appcmd.exe add apppool /name:"Contoso"

appcmd.exe set config -section:system.applicationHost/applicationPools /+"[name='Contoso'].recycling.periodicRestart.schedule.[value='03:00:00']" /commit:apphost