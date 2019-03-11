appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/iisClientCertificateMappingAuthentication 
	/enabled:"True" /oneToOneCertificateMappingsEnabled:"True"  /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/iisClientCertificateMappingAuthentication 
	/+"oneToOneMappings.[userName='testUser',password='securePassWord!1',certificate='CERTIFICATE_BLOB']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/access /sslFlags:"Ssl, SslNegotiateCert, Ssl128"  /commit:apphost