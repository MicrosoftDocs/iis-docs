appcmd.exe set config "contentSite" -section:system.webServer/cors /enabled:"True" /failUnlistedOrigins:"True"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='*']"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120']"
appcmd.exe set config "contentSite" -section:system.webServer/cors /[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120'].allowHeaders.allowAllRequestedHeaders:"True"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120'].allowHeaders.[header='header1']"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120'].allowHeaders.[header='header2']"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120'].allowMethods.[method='DELETE']"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120'].exposeHeaders.[header='header1']"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='https://*.microsoft.com',allowCredentials='True',maxAge='120'].exposeHeaders.[header='header2']"

appcmd.exe set config "contentSite" -section:system.webServer/cors /+"[origin='http://*',allowed='False']"
