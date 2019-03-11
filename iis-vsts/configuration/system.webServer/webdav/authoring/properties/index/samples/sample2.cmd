appcmd.exe set config "Default Web Site" -section:system.webServer/webdav/authoring /properties.allowAnonymousPropfind:"False" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/webdav/authoring /properties.allowInfinitePropfindDepth:"False" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/webdav/authoring /properties.allowCustomProperties:"True" /commit:apphost

appcmd.exe set config "Default Web Site" -section:system.webServer/webdav/authoring /+"properties.[xmlNamespace='*',propertyStore='webdav_simple_prop']" /commit:apphost