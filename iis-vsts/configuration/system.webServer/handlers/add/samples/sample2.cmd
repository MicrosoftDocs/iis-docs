appcmd.exe set config -section:system.webServer/fastCgi /+"[fullPath='c:\php\php-cgi.exe']" /commit:apphost

appcmd.exe set config "Contoso" -section:system.webServer/handlers /+"[name='PHP-FastCGI',path='*.php',verb='GET,HEAD,POST',modules='FastCgiModule',scriptProcessor='c:\php\php-cgi.exe',resourceType='Either']"