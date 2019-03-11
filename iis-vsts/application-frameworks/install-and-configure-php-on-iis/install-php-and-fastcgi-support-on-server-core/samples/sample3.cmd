AppCmd set config /section:system.webServer/fastCGI /+[fullPath='d:\php\php-cgi.exe']

AppCmd set config /section:system.webServer/handlers /+[name='PHP-FastCGI',path='*.php',verb='*',modules='FastCgiModule',scriptProcessor='d:\php\php-cgi.exe',resourceType='Either']