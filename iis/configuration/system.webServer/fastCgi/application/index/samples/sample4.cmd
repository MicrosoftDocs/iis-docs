appcmd.exe set config -section:system.webServer/fastCgi /+"[fullPath='C:\PHP\php-cgi.exe',arguments='',maxInstances='4',idleTimeout='300',activityTimeout='30',requestTimeout='90',instanceMaxRequests='10000',protocol='NamedPipe',flushNamedPipe='False']" /commit:apphost

appcmd.exe set config -section:system.webServer/fastCgi /+"[fullPath='C:\PHP\php-cgi.exe'].environmentVariables.[name='PHP_FCGI_MAX_REQUESTS',value='10000']" /commit:apphost

appcmd.exe set config -section:system.webServer/handlers /+"[name='PHP-FastCGI',path='*.php',verb='GET,HEAD,POST',modules='FastCgiModule',scriptProcessor='C:\PHP\php-cgi.exe',resourceType='Either',requireAccess='Script']" /commit:apphost