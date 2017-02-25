> $sites = get-iissite -computer test-server 
>$sites[0]

ApplicationDefaults        : @{ApplicationPool=; EnabledProtocols=http; Path=}
Bindings                   : {@{BindingInformation=*:80:; Protocol=http}}
Id                         : 1
Limits                     : @{ConnectionTimeout=00000000000200.000000:000; Max
                             Bandwidth=4294967295; MaxConnections=4294967295}
LogFile                    : @{CustomLogPluginClsid=; Directory=%SystemDrive%\i
                             netpub\logs\LogFiles; Enabled=True; LocalTimeRollo
                             ver=False; LogExtFileFlags=2199503; LogFormat=2; P
                             eriod=1; TruncateSize=20971520}
Name                       : Default Web Site
ServerAutoStart            : True
TraceFailedRequestsLogging : @{Directory=%SystemDrive%\inetpub\logs\FailedReqLo
                             gFiles; Enabled=False; MaxLogFiles=50}
VirtualDirectoryDefaults   : @{AllowSubDirConfig=True; LogonMethod=3; Password=
                             ; Path=; PhysicalPath=; UserName=}
Computer                   : test-server 
Credential                 : System.Management.Automation.PSCredential
 
>$sites[0].Limits

ConnectionTimeout                        MaxBandwidth            MaxConnections
-----------------                        ------------            --------------
00000000000200.000000:000                  4294967295                4294967295
 
> $sites[0].Limits.MaxBandwidth
4294967295