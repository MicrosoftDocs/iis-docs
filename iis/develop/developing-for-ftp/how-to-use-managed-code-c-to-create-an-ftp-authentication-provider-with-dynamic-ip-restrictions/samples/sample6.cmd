cd %SystemRoot%\System32\Inetsrv

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"[name='FtpAddressRestrictionAuthentication',type='FtpAddressRestrictionAuthentication,FtpAddressRestrictionAuthentication,version=1.0.0.0,Culture=neutral,PublicKeyToken=426f62526f636b73']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpAddressRestrictionAuthentication']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpAddressRestrictionAuthentication'].[key='connectionString',value='Server=localhost;Database=FtpAuthentication;User ID=FtpLogin;Password=P@ssw0rd']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpAddressRestrictionAuthentication'].[key='logonAttempts',value='5']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpAddressRestrictionAuthentication'].[key='floodSeconds',value='30']" /commit:apphost