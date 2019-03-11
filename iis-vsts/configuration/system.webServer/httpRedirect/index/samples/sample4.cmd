appcmd.exe set config "Default Web Site" -section:system.webServer/httpRedirect /enabled:"True"
appcmd.exe set config "Default Web Site" -section:system.webServer/httpRedirect /destination:"http://www.contoso.com"
appcmd.exe set config "Default Web Site" -section:system.webServer/httpRedirect /exactDestination:"False"
appcmd.exe set config "Default Web Site" -section:system.webServer/httpRedirect /httpResponseStatus:"Found"