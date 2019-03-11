appcmd.exe set config "Default Web Site" -section:system.webServer/webdav/authoringRules /allowNonMimeMapFiles:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/webdav/authoringRules /+"[roles='administrators',path='*',access='Read, Write, Source']" /commit:apphost