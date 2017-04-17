cd /d "%WinDir%\System32\Inetsrv"

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"[name='FtpLeechPrevention',type='FtpLeechPrevention,FtpLeechPrevention,version=1.0.0.0,Culture=neutral,PublicKeyToken=426f62526f636b73']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpLeechPrevention']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpLeechPrevention'].[key='MaxDownloads',value='5']" /commit:apphost