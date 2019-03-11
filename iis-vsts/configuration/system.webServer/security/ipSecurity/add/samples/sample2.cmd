appcmd.exe set config "Default Web Site" -section:system.webServer/security/ipSecurity /+"[ipAddress='192.168.100.1',allowed='False']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/ipSecurity /+"[ipAddress='169.254.0.0',subnetMask='255.255.0.0',allowed='False']" /commit:apphost