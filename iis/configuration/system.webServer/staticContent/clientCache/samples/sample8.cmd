appcmd.exe set config "Default Web Site" -section:system.webServer/staticContent /clientCache.cacheControlMode:"UseExpires"

appcmd.exe set config "Default Web Site" -section:system.webServer/staticContent /clientCache.httpExpires:"Tue, 19 Jan 2038 03:14:07 GMT"