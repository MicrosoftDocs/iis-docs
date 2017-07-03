appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso'].bindings.[protocol='http',bindingInformation='192.168.0.1:80:www.contoso.com']" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /+"[name='Contoso'].bindings.[protocol='https',bindingInformation='*:443:']" /commit:apphost