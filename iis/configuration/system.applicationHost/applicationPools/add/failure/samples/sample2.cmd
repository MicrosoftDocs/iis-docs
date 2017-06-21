appcmd.exe set config -section:system.applicationHost/applicationPools /[name='DefaultAppPool'].failure.rapidFailProtection:"True" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /[name='DefaultAppPool'].failure.rapidFailProtectionInterval:"00:05:00" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /[name='DefaultAppPool'].failure.rapidFailProtectionMaxCrashes:"5" /commit:apphost