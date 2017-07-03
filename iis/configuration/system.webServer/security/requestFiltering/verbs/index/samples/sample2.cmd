appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /verbs.applyToWebDAV:"False"

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"verbs.[verb='PUT',allowed='False']"