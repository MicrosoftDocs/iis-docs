appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /fileExtensions.applyToWebDAV:"False"

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"fileExtensions.[fileExtension='inc',allowed='False']"