cd %SystemRoot%\System32\Inetsrv

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"[name='FtpXmlAuthentication',type='FtpXmlAuthentication,FtpXmlAuthentication,version=1.0.0.0,Culture=neutral,PublicKeyToken=426f62526f636b73']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpXmlAuthentication']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpXmlAuthentication'].[key='xmlFileName',value='C:\Inetpub\XmlSample\Users.xml']" /commit:apphost