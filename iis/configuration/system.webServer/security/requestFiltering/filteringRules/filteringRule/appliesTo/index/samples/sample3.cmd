appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"filteringRules.[name='Block Image Leeching',scanUrl='False',scanQueryString='False',scanAllRaw='False']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"filteringRules.[name='Block Image Leeching'].scanHeaders.[requestHeader='User-agent']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"filteringRules.[name='Block Image Leeching'].appliesTo.[fileExtension='.gif']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"filteringRules.[name='Block Image Leeching'].appliesTo.[fileExtension='.jpg']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"filteringRules.[name='Block Image Leeching'].appliesTo.[fileExtension='.png']" 

appcmd.exe set config "Default Web Site" -section:system.webServer/security/requestFiltering /+"filteringRules.[name='Block Image Leeching'].denyStrings.[string='leech-bot']"