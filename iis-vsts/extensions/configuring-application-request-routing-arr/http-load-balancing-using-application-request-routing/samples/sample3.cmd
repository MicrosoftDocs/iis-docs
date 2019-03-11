appcmd.exe set config -section:system.webServer/rewrite/globalRules
/+"[name='ARR_myServerFarm_loadbalance_SSL',patternSyntax='Wildcard',stopProcessing='True']"
/commit:apphost

appcmd.exe set config -section:system.webServer/rewrite/globalRules
/[name='ARR_myServerFarm_loadbalance_SSL',patternSyntax='Wildcard',stopProcessing='True'].match.url:"*"
/commit:apphost

appcmd.exe set config -section:system.webServer/rewrite/globalRules
/+"[name='ARR_myServerFarm_loadbalance_SSL',patternSyntax='Wildcard',stopProcessing='True'].conditions.[input='{HTTPS}',pattern='On']"
/commit:apphost

appcmd.exe set config -section:system.webServer/rewrite/globalRules
/[name='ARR_myServerFarm_loadbalance_SSL',patternSyntax='Wildcard',stopProcessing='True'].action.type:"Rewrite"
/[name='ARR_myServerFarm_loadbalance_SSL',patternSyntax='Wildcard',stopProcessing='True'].action.url:"https://myServerFarm/{R:0}"
/commit:apphost