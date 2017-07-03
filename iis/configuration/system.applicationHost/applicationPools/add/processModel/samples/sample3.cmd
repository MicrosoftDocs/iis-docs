appcmd.exe set config -section:system.applicationHost/applicationPools /[name='Contoso'].processModel.shutdownTimeLimit:"00:00:30" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /[name='Contoso'].processModel.startupTimeLimit:"00:00:30" /commit:apphost