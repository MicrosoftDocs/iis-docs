appcmd.exe set site /site.name:Contoso /+bindings.[protocol='http',bindingInformation='192.168.0.1:80:www.contoso.com']

appcmd.exe set site /site.name:Contoso /+bindings.[protocol='https',bindingInformation='*:443:']