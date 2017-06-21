appcmd.exe set config "Default Web Site" -section:system.webServer/urlCompression /doDynamicCompression:"False" 

appcmd.exe set config "Default Web Site" -section:system.webServer/urlCompression /doStaticCompression:"True"