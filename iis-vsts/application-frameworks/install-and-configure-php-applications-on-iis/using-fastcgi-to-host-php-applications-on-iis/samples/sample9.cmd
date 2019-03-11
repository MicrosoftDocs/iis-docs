C:\>%windir%\system32\inetsrv\appcmd set config site1 –section:system.webServer/handlers /+"..[name=’PHP448_via_FastCGI’,path=’*.php’,verb=’*’,modules=’FastCgiModule’,scriptProcessor=’c:\php448\php.exe’,resourceType=’Either’]

C:\>%windir%\system32\inetsrv\appcmd set config site2 –section:system.webServer/handlers /+"..[name=’PHP521_via_FastCGI’,path=’*.php’,verb=’*’,modules=’FastCgiModule’,scriptProcessor=’c:\php521\php-cgi.exe’,resourceType=’Either’]

C:\>%windir%\system32\inetsrv\appcmd set config site3 –section:system.webServer/handlers /+"..[name=’PHP525nts_via_FastCGI’,path=’*.php’,verb=’*’,modules=’FastCgiModule’,scriptProcessor=’c:\php525nts\php-cgi.exe’,resourceType=’Either’]