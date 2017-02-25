cd %SystemRoot%\System32\Inetsrv

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"[name='FtpXmlAuthorization',type='FtpXmlAuthorization,FtpXmlAuthorization,version=1.0.0.0,Culture=neutral,PublicKeyToken=426f62526f636b73']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpXmlAuthorization']" /commit:apphost

appcmd.exe set config -section:system.ftpServer/providerDefinitions /+"activation.[name='FtpXmlAuthorization'].[key='xmlFileName',value='C:\Inetpub\XmlSample\Users.xml']" /commit:apphost