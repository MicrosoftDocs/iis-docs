appcmd.exe set config  -section:system.webServer/rewrite/globalRules 
/+"[name='ARR_myServerFarm_loadbalance',patternSyntax='Wildcard',stopProcessing='True'].conditions.
[input='{URL}',negate='True',pattern='*/images/*']" 
/commit:apphost