appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"denyUrlSequences.[sequence='..']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"denyUrlSequences.[sequence=':']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"denyUrlSequences.[sequence='\']"