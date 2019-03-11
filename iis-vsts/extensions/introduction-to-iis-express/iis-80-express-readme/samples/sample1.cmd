appcmd.exe set config -section:system.applicationHost/sites /+"[name='www.fabrikam.com',id='2112']
" /commit:apphost 
/AppHostConfig:C:\Temp\IISExpress\config\ApplicationHost.config

appcmd.exe set config -section:system.applicationHost/sites /+"[name='www.fabrikam.com',id='2112']
.bindings.[protocol='http',bindingInformation=':8080:localhost']" /commit:apphost 
/AppHostConfig:C:\Temp\IISExpress\config\ApplicationHost.config

appcmd.exe set config -section:system.applicationHost/sites /+"[name='www.fabrikam.com',id='2112']
.[path='/']" /commit:apphost 
/AppHostConfig:C:\Temp\IISExpress\config\ApplicationHost.config

appcmd.exe set config -section:system.applicationHost/sites /+"[name='www.fabrikam.com',id='2112']
.[path='/'].[path='/',physicalPath='C:\Inetpub\www.fabrikam.com']" /commit:apphost 
/AppHostConfig:C:\Temp\IISExpress\config\ApplicationHost.config