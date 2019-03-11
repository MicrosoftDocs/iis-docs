appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/iisClientCertificateMappingAuthentication /enabled:"True" /manyToOneCertificateMappingsEnabled:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/iisClientCertificateMappingAuthentication /+"manyToOneMappings.[name='Contoso Employees',enabled='True',permissionMode='Allow',userName='Username',password='Password']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/authentication/iisClientCertificateMappingAuthentication /+"manyToOneMappings.[name='Contoso Employees'].rules.[certificateField='Subject',certificateSubField='O',matchCriteria='Contoso',compareCaseSensitive='True']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/access /sslFlags:"Ssl, SslNegotiateCert" /commit:apphost