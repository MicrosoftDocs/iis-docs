%windir%\system32\inetsrv\Appcmd add AppPool -name:%poolname% -processModel.username:%poolaccount% -processModel.password:%poolaccountpwd% -enable32BitAppOnWin64:true

%windir%\system32\inetsrv\AppCmd add site -name:%sitename% -bindings:http/*:80:%sitename% -physicalPath:%sitepath% -logfile.directory:%W3svclogpath% -traceFailedRequestsLogging.directory:%FREBlogpath%

%windir%\system32\inetsrv\Appcmd set app -app.name:%sitename%/ -applicationPool:%poolname%