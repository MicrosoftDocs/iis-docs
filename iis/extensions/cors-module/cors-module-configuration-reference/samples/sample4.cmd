Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors" -name "enabled" -value "True"
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors" -name "failUnlistedOrigins" -value "True"

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors" -name "." -value @{origin='*'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors" -name "." -value @{origin='https://*.microsoft.com';allowCredentials='True';maxAge=120}
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors/add[@origin='https://*.microsoft.com']/allowHeaders" -name "allowAllRequestedHeaders" -value "True"

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors/add[@origin='https://*.microsoft.com']/allowHeaders" -name "." -value @{header='header1'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors/add[@origin='https://*.microsoft.com']/allowHeaders" -name "." -value @{header='header2'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors/add[@origin='https://*.microsoft.com']/allowMethods" -name "." -value @{method='DELETE'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors/add[@origin='https://*.microsoft.com']/exposeHeaders" -name "." -value @{header='header1'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors/add[@origin='https://*.microsoft.com']/exposeHeaders" -name "." -value @{header='header2'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/contentSite'  -filter "system.webServer/cors" -name "." -value @{origin='http://*';allowed='False'}
