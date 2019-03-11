cd /d "%SystemRoot%\System32\Inetsrv"
Appcmd.exe set config -section:system.ftpServer/caching /credentialsCache.enabled:"False" /commit:apphost
Net stop FTPSVC
Net start FTPSVC