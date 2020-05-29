%windir%\System32\inetsrv\appcmd.exe add site /name:"webmail" /bindings:http/*:8081: /physicalPath:"%SystemDrive%\inetpub\webmail"

%windir%\System32\inetsrv\appcmd.exe add site /name:"payroll" /bindings:http/*:8082: /physicalPath:"%SystemDrive%\inetpub\payroll"
