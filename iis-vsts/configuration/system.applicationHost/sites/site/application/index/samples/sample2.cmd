appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso'].[path='/ShoppingCart']" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso'].[path='/ShoppingCart'].[path='/',physicalPath='C:\Inetpub\Contoso\ShoppingCart']" /commit:apphost