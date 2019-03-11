appcmd.exe set config  -section:system.webServer/rewrite/globalRules 
/+"[name='ARR_myServerFarm_loadbalance',patternSyntax='Wildcard',stopProcessing='True'].conditions.
[input='EXT_{URL}',negate='True',pattern='*.css']" 
/commit:apphost