appcmd.exe set config -section:system.applicationHost/configHistory /enabled:"True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/configHistory /path:"%SystemDrive%\inetpub\history" /commit:apphost
appcmd.exe set config -section:system.applicationHost/configHistory /maxHistories:"50" /commit:apphost
appcmd.exe set config -section:system.applicationHost/configHistory /period:"00:05:00" /commit:apphost