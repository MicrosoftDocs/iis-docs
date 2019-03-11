REM Configure FTP sites to start automatically by default.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.serverAutoStart:"True" /commit:apphost

REM Configure the default control channel time-out for 300 seconds.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.connections.controlChannelTimeout:"300" /commit:apphost

REM Configure the default FTP security options.
appcmd.exe set config -section:system.applicationHost/sites /+"siteDefaults.ftpServer.security.commandFiltering.[command='SYST',allowed='False']" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.ssl.controlChannelPolicy:"SslAllow" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.ssl.dataChannelPolicy:"SslAllow" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.ssl.serverCertHash:"57686f6120447564652c2049495320526f636b73" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.authentication.anonymousAuthentication.enabled:"False" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.authentication.basicAuthentication.enabled:"False" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.authentication.clientCertAuthentication.enabled:"False" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.sslClientCertificates.clientCertificatePolicy:"CertIgnore" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /+"siteDefaults.ftpServer.security.authentication.customAuthentication.providers.[name='FtpCustomAuthenticationModule',enabled='False']" /commit:apphost

REM Configure a custom default banner message and local detailed error messages.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.messages.bannerMessage:"Welcome!" /siteDefaults.ftpServer.messages.allowLocalDetailedErrors:"True" /commit:apphost

REM Configure the FTP service to keep partially-uploaded files by default.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.fileHandling.keepPartialUploads:"False" /commit:apphost

REM Configure the default external IP address of a firewall.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.firewallSupport.externalIp4Address:"169.254.10.10" /commit:apphost

REM Specify no user isolation by default.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.userIsolation.mode:"None" /commit:apphost

REM Configure UNIX-style directory listings by default and display the available drive space.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.directoryBrowse.showFlags:"StyleUnix, DisplayAvailableBytes" /commit:apphost

REM Enable logging by default with daily log file rollover.
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.logFile.period:"Daily" /siteDefaults.ftpServer.logFile.enabled:"True" /commit:apphost