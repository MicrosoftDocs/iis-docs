appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso',id='2',serverAutoStart='True']" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso',id='2'].bindings.[protocol='http',bindingInformation='*:80:www.contoso.com']" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso',id='2'].[path='/']" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso',id='2'].[path='/'].[path='/',physicalPath='C:\Inetpub\www.contoso.com\wwwroot']" /commit:apphost