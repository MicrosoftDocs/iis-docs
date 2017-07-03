appcmd.exe set config "Default Web Site" -section:system.webServer/staticContent /+"[fileExtension='syx',mimeType='application/octet-stream']"

appcmd.exe set config "Default Web Site" -section:system.webServer/staticContent /+"[fileExtension='tab',mimeType='text/plain']"