appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"[name='FtpMailDemo',type='FtpMailDemo,FtpMailDemo,version=1.0.0.0,Culture=neutral,PublicKeyToken=426f62526f636b73']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpMailDemo']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpMailDemo'].[key='smtpServerName',value='localhost']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpMailDemo'].[key='smtpServerPort',value='25']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpMailDemo'].[key='smtpFromAddress',value='someone@contoso.com']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpMailDemo'].[key='smtpToAddress',value='someone@contoso.com']" /commit:apphost