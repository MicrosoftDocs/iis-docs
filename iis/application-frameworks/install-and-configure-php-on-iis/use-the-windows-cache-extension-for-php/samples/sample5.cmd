appcmd.exe set config  -section:system.webServer/fastCgi
/[fullPath='C:\PHP\php-cgi.exe',arguments=''].maxInstances:"32"  
/commit:apphost