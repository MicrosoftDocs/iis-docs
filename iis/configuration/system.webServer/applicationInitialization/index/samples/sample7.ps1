Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "remapManagedRequestsTo" -value "HelloJoe.htm"
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "skipManagedModules" -value "True"
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "doAppInitAfterRestart" -value "True"

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST' -location 'Default Web Site' -filter "system.webServer/applicationInitialization" -name "." -value @{initializationPage='JoesSite.htm';hostName='JoesHost'}