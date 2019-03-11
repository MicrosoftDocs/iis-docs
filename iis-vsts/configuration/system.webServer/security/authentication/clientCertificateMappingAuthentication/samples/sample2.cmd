appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/clientCertificateMappingAuthentication /enabled:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/access /sslFlags:"Ssl, SslNegotiateCert" /commit:apphost