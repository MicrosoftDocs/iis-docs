appcmd.exe set config "Default Web Site" -section:system.webServer/applicationInitialization /remapManagedRequestsTo:"HelloJoe.htm" /skipManagedModules:"True" /doAppInitAfterRestart:"True"  /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/applicationInitialization /+"[initializationPage='JoesSite.htm',hostName='JoesHost']" /commit:apphost