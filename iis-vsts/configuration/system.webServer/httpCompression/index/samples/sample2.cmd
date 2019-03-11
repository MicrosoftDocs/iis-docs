appcmd.exe set config -section:system.webServer/httpCompression /+"dynamicTypes.[mimeType='application/msword',enabled='True']" /commit:apphost

appcmd.exe set config -section:system.webServer/httpCompression /+"dynamicTypes.[mimeType='application/vnd.ms-powerpoint',enabled='True']" /commit:apphost

appcmd.exe set config -section:system.webServer/httpCompression /+"dynamicTypes.[mimeType='application/vnd.ms-excel',enabled='True']" /commit:apphost