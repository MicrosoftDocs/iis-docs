appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.ssl.controlChannelPolicy:"SslAllow" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.ssl.dataChannelPolicy:"SslAllow" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.ssl.serverCertHash:"57686f6120447564652c2049495320526f636b73" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.authentication.clientCertAuthentication.enabled:"True" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.sslClientCertificates.clientCertificatePolicy:"CertIgnore" /commit:apphost
appcmd.exe set config -section:system.applicationHost/sites /siteDefaults.ftpServer.security.sslClientCertificates.useActiveDirectoryMapping:"True" /commit:apphost