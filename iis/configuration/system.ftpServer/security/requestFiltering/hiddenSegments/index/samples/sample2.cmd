appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/requestFiltering /+"hiddenSegments.[segment='bin']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.ftpServer/security/requestFiltering /+"hiddenSegments.[segment='App_Code']" /commit:apphost