%WINDIR%\system32\inetsrv\appcmd.exe set config -section:system.webServer/security/dynamicIpSecurity 
/denyByConcurrentRequests.enabled:"True" 
/denyByConcurrentRequests.maxConcurrentRequests:"2" 
/commit:apphost