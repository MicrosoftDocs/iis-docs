appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/ipSecurity /allowUnlisted:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/ipSecurity /+"[ipAddress='127.0.0.1',allowed='True']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/ipSecurity /+"[ipAddress='169.254.0.0',subnetMask='255.255.0.0']" /commit:apphost