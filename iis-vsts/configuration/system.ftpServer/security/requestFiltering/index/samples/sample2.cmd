appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/requestFiltering /+"fileExtensions.[fileExtension='.exe',allowed='False']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/requestFiltering /+"fileExtensions.[fileExtension='.com',allowed='False']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/requestFiltering /+"fileExtensions.[fileExtension='.cmd',allowed='False']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/requestFiltering /+"fileExtensions.[fileExtension='.bat',allowed='False']" /commit:apphost