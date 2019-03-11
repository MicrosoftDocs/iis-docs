appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /hiddenSegments.applyToWebDAV:"False"

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"hiddenSegments.[segment='_private']"