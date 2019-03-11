appcmd.exe set config "Default Web Site" -section:system.webServer/httpRedirect /enabled:"True" /exactDestination:"True" /httpResponseStatus:"Found"

appcmd.exe set config "Default Web Site" -section:system.webServer/httpRedirect /+"[wildcard='*.asp',destination='/default.htm']"