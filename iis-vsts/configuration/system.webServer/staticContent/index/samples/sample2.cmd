appcmd.exe set config "Default Web Site" -section:system.webServer/staticContent /enableDocFooter:"True"

appcmd.exe set config "Default Web Site" -section:system.webServer/staticContent /defaultDocFooter:"The information in this web site is copyrighted."