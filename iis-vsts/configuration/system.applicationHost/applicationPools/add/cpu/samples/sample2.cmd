appcmd.exe set config -section:system.applicationHost/applicationPools /[name='DefaultAppPool'].cpu.action:"KillW3wp" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /[name='DefaultAppPool'].cpu.resetInterval:"00:04:00" /commit:apphost