appcmd.exe set config -section:system.webServer/webdav/globalSettings /+"propertyStores.[name='webdav_simple_prop',image='%windir%\system32\inetsrv\webdav_simple_prop.dll']" /commit:apphost

appcmd.exe set config -section:system.webServer/webdav/globalSettings /+"lockStores.[name='webdav_simple_lock',image='%windir%\system32\inetsrv\webdav_simple_lock.dll']" /commit:apphost