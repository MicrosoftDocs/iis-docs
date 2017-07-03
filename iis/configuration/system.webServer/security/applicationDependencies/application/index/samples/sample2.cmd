appcmd.exe set config "Default Web Site" -section:system.webServer/security/applicationDependencies /+"[name='My Custom Application',groupId='MyCustomGroup']" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/security/applicationDependencies /+"[name='My Custom Application',groupId='MyCustomGroup'].[groupId='ASP']" /commit:apphost